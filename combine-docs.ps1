# PowerShell script to combine all markdown files in /docs into a single file
# Author: GitHub Copilot
# Date: $(Get-Date -Format 'yyyy-MM-dd')

param(
    [string]$OutputFile = "Combined_Documentation.md"
)

# Set the docs folder path
$DocsPath = Join-Path -Path $PSScriptRoot -ChildPath "docs"
$OutputPath = Join-Path -Path $PSScriptRoot -ChildPath $OutputFile

# Verify docs folder exists
if (-not (Test-Path -Path $DocsPath)) {
    Write-Error "Docs folder not found at: $DocsPath"
    exit 1
}

Write-Host "Starting documentation combination process..." -ForegroundColor Green
Write-Host "Source folder: $DocsPath" -ForegroundColor Yellow
Write-Host "Output file: $OutputPath" -ForegroundColor Yellow

# Initialize the combined content
$CombinedContent = @()

# Add header with timestamp
$CombinedContent += "# PUBG UGC Complete Documentation"
$CombinedContent += ""
$CombinedContent += "*Generated on: $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')*"
$CombinedContent += ""
$CombinedContent += "---"
$CombinedContent += ""

# Function to add file content with proper formatting
function Add-FileContent {
    param(
        [string]$FilePath,
        [string]$SectionTitle = ""
    )
    
    if (Test-Path -Path $FilePath) {
        Write-Host "Adding: $FilePath" -ForegroundColor Cyan
        
        # Add section separator if title provided
        if ($SectionTitle) {
            [void]$CombinedContent.Add("")
            [void]$CombinedContent.Add("---")
            [void]$CombinedContent.Add("")
            [void]$CombinedContent.Add("# $SectionTitle")
            [void]$CombinedContent.Add("")
        }
        
        # Read and add file content with proper UTF-8 encoding
        $FileContent = Get-Content -Path $FilePath -Raw -Encoding UTF8
        if ($FileContent) {
            [void]$CombinedContent.Add($FileContent.TrimEnd())
        }
        
        # Add spacing after content
        [void]$CombinedContent.Add("")
        [void]$CombinedContent.Add("")
        
        return $true
    } else {
        Write-Warning "File not found: $FilePath"
        return $false
    }
}

# Function to process a folder and add all markdown files
function Add-FolderContent {
    param(
        [string]$FolderPath,
        [string]$SectionTitle = ""
    )
    
    if (-not (Test-Path -Path $FolderPath)) {
        Write-Warning "Folder not found: $FolderPath"
        return
    }
    
    Write-Host "Processing folder: $FolderPath" -ForegroundColor Magenta
    
    # Add section header if provided
    if ($SectionTitle) {
        [void]$CombinedContent.Add("")
        [void]$CombinedContent.Add("---")
        [void]$CombinedContent.Add("")
        [void]$CombinedContent.Add("# $SectionTitle")
        [void]$CombinedContent.Add("")
    }
    
    # Check for README file first
    $ReadmeFile = Join-Path -Path $FolderPath -ChildPath "README.md"
    if (Test-Path -Path $ReadmeFile) {
        [void](Add-FileContent -FilePath $ReadmeFile -SectionTitle "Overview")
    }
    
    # Get all other markdown files (excluding README)
    $MarkdownFiles = Get-ChildItem -Path $FolderPath -Filter "*.md" | 
                     Where-Object { $_.Name -ne "README.md" } |
                     Sort-Object Name
    
    foreach ($File in $MarkdownFiles) {
        $FileTitle = [System.IO.Path]::GetFileNameWithoutExtension($File.Name)
        [void](Add-FileContent -FilePath $File.FullName -SectionTitle $FileTitle)
    }
}

# Convert to ArrayList for better performance
$CombinedContent = [System.Collections.ArrayList]$CombinedContent

# 1. README
Write-Host "`n=== Processing Main Files ===" -ForegroundColor Yellow
$ReadmePath = Join-Path -Path $DocsPath -ChildPath "README.md"
[void](Add-FileContent -FilePath $ReadmePath -SectionTitle "Introduction")

# 2. UGCMap
$UGCMapPath = Join-Path -Path $DocsPath -ChildPath "UGCMap.md"
[void](Add-FileContent -FilePath $UGCMapPath -SectionTitle "UGC Map")

# 3. Settings
$SettingsPath = Join-Path -Path $DocsPath -ChildPath "Settings.md"
[void](Add-FileContent -FilePath $SettingsPath -SectionTitle "Settings")

# 4. Objects
$ObjectsPath = Join-Path -Path $DocsPath -ChildPath "Objects.md"
[void](Add-FileContent -FilePath $ObjectsPath -SectionTitle "Objects")

# 5. Devices (main file)
$DevicesPath = Join-Path -Path $DocsPath -ChildPath "Devices.md"
[void](Add-FileContent -FilePath $DevicesPath -SectionTitle "Devices Overview")

# 6. General folder content
Write-Host "`n=== Processing General Folder ===" -ForegroundColor Yellow
$GeneralPath = Join-Path -Path $DocsPath -ChildPath "General"
Add-FolderContent -FolderPath $GeneralPath -SectionTitle "General Documentation"

# 7. Devices folder content
Write-Host "`n=== Processing Devices Folder ===" -ForegroundColor Yellow
$DevicesFolderPath = Join-Path -Path $DocsPath -ChildPath "Devices"
Add-FolderContent -FolderPath $DevicesFolderPath -SectionTitle "Device Documentation"

# 8. Guides folder content
Write-Host "`n=== Processing Guides Folder ===" -ForegroundColor Yellow
$GuidesFolderPath = Join-Path -Path $DocsPath -ChildPath "Guides"
Add-FolderContent -FolderPath $GuidesFolderPath -SectionTitle "Guides Documentation"

# Write the combined content to output file
Write-Host "`n=== Writing Combined Documentation ===" -ForegroundColor Yellow
try {
    # Join all content with newlines
    $FinalContent = $CombinedContent -join "`n"
    
    # Post-process: Remove all image references from the documentation
    Write-Host "Post-processing: Removing image references..." -ForegroundColor Cyan
    
    # Remove HTML img tags completely
    $FinalContent = $FinalContent -replace '<img[^>]*>', ''
    
    # Remove markdown image syntax
    $FinalContent = $FinalContent -replace '!\[[^\]]*\]\([^)]*\)', ''
    
    # Clean up any extra blank lines that might result from image removal
    $FinalContent = $FinalContent -replace '(\r?\n){3,}', "`n`n"
    
    # Write to file with UTF-8 encoding (no BOM)
    $Utf8NoBomEncoding = New-Object System.Text.UTF8Encoding $False
    [System.IO.File]::WriteAllText($OutputPath, $FinalContent, $Utf8NoBomEncoding)
    
    Write-Host "Successfully created combined documentation!" -ForegroundColor Green
    Write-Host "Output file: $OutputPath" -ForegroundColor Green
    
    # Show file statistics
    $FileInfo = Get-Item -Path $OutputPath
    $LineCount = ($FinalContent -split "`n").Count
    Write-Host "File size: $([math]::Round($FileInfo.Length / 1KB, 2)) KB" -ForegroundColor Cyan
    Write-Host "Total lines: $LineCount" -ForegroundColor Cyan
    
} catch {
    Write-Error "Failed to write output file: $_"
    exit 1
}

Write-Host "`nDocumentation combination completed successfully!" -ForegroundColor Green
