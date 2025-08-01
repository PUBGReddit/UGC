using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using PUBG.Reddit.UGC.Models;

// Create class to store device naming information
public class DeviceNameInfo 
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

namespace Testing
{
    class Program
    {
        private const string DefaultDevicesPath = @"d:\Devs\PUBG.UGC\src\DefaultDevices.json";
        private const string DeviceNamingPath = @"d:\Devs\PUBG.UGC\src\DeviceNaming.json";
        
        static void Main(string[] args)
        {
            Console.WriteLine("Loading device configuration and naming information from JSON...");
            
            try
            {
                // Configure JSON options to be case insensitive
                var jsonOptions = CreateJsonOptions();
                
                // Load device naming information
                var deviceNaming = LoadDeviceNaming(DeviceNamingPath, jsonOptions);
                
                // Load device configurations
                var devicesList = LoadDeviceConfigurations(DefaultDevicesPath, jsonOptions);
                
                if (devicesList == null || !devicesList.Any() || deviceNaming == null)
                {
                    Console.WriteLine("Failed to load device configurations or naming information.");
                    return;
                }
                
                // Organize devices by type for easier access
                var devicesByType = OrganizeDevicesByType(devicesList);
                
                // Display device information
                DisplayDeviceInformation(devicesByType, deviceNaming);
                
                // Create and display device instances
                var deviceInstances = CreateDeviceInstances(devicesByType, deviceNaming, jsonOptions);
                DisplayDeviceInstances(deviceInstances);
            }
            catch (Exception ex)
            {
                HandleException(ex, DefaultDevicesPath);
            }
            
            Console.WriteLine("\nPress any key to exit...");
        }
        
        private static JsonSerializerOptions CreateJsonOptions()
        {
            return new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
                Converters = { new JsonStringEnumConverter() }
            };
        }
        
        private static Dictionary<string, DeviceNameInfo> LoadDeviceNaming(string path, JsonSerializerOptions options)
        {
            try
            {
                string namingContent = File.ReadAllText(path);
                var deviceNaming = JsonSerializer.Deserialize<Dictionary<string, DeviceNameInfo>>(namingContent, options);
                Console.WriteLine($"Successfully loaded device naming information for {deviceNaming?.Count ?? 0} device types.");
                return deviceNaming ?? new Dictionary<string, DeviceNameInfo>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading device naming information: {ex.Message}");
                return new Dictionary<string, DeviceNameInfo>();
            }
        }
        
        private static List<JsonElement> LoadDeviceConfigurations(string path, JsonSerializerOptions options)
        {
            try
            {
                string jsonContent = File.ReadAllText(path);
                var deviceList = JsonSerializer.Deserialize<List<JsonElement>>(jsonContent, options);
                return deviceList ?? new List<JsonElement>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading device configurations: {ex.Message}");
                return new List<JsonElement>();
            }
        }
        
        private static Dictionary<string, JsonElement> OrganizeDevicesByType(List<JsonElement> devicesList)
        {
            var devicesByType = new Dictionary<string, JsonElement>();
            
            foreach (var device in devicesList)
            {
                if (device.TryGetProperty("DeviceType", out JsonElement typeElement) && 
                    typeElement.ValueKind == JsonValueKind.String)
                {
                    string deviceType = typeElement.GetString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(deviceType))
                    {
                        devicesByType[deviceType] = device;
                    }
                }
            }
            
            Console.WriteLine($"Successfully organized {devicesByType.Count} device configurations from array format.");
            return devicesByType;
        }
        
        private static void DisplayDeviceInformation(Dictionary<string, JsonElement> devicesByType, Dictionary<string, DeviceNameInfo> deviceNaming)
        {
            Console.WriteLine("\nAvailable device types and their properties:");
            
            foreach (var (deviceType, properties) in devicesByType)
            {
                // Get friendly name and description
                GetDeviceDisplayInfo(deviceType, deviceNaming, out string displayName, out string description);
                
                Console.WriteLine($"\n## {displayName} ({deviceType})");
                if (!string.IsNullOrEmpty(description))
                {
                    Console.WriteLine($"Description: {description}");
                }
                
                // Display properties
                DisplayDeviceProperties(properties);
            }
        }
        
        private static void GetDeviceDisplayInfo(string deviceType, Dictionary<string, DeviceNameInfo> deviceNaming, 
            out string displayName, out string description)
        {
            displayName = deviceType;
            description = string.Empty;
            
            if (deviceNaming.TryGetValue(deviceType, out var nameInfo))
            {
                displayName = nameInfo.Name;
                description = nameInfo.Description;
            }
        }
        
        private static void DisplayDeviceProperties(JsonElement properties)
        {
            Console.WriteLine("Properties:");
            foreach (var property in properties.EnumerateObject())
            {
                string valueStr = FormatPropertyValue(property.Value);
                Console.WriteLine($"  - {property.Name}: {valueStr}");
            }
        }
        
        private static string FormatPropertyValue(JsonElement value)
        {
            return value.ValueKind switch
            {
                JsonValueKind.Array => $"[Array with {value.GetArrayLength()} elements]",
                JsonValueKind.Object => "[Object]",
                _ => value.ToString()
            };
        }
        
        private static Dictionary<string, DeviceBase> CreateDeviceInstances(
            Dictionary<string, JsonElement> devicesByType, 
            Dictionary<string, DeviceNameInfo> deviceNaming,
            JsonSerializerOptions jsonOptions)
        {
            var deviceInstances = new Dictionary<string, DeviceBase>();
            
            foreach (var (deviceType, properties) in devicesByType)
            {
                try
                {
                    // The device JSON already has DeviceType property included
                    var propertiesJson = properties.ToString();
                    
                    // Create a device of the appropriate type using polymorphic deserialization
                    var device = JsonSerializer.Deserialize<DeviceBase>(propertiesJson, jsonOptions);
                    
                    if (device != null)
                    {
                        // Set the name and description from the naming information
                        if (deviceNaming.TryGetValue(deviceType, out var naming))
                        {
                            device.Name = naming.Name;
                            device.Description = naming.Description;
                        }
                        else
                        {
                            device.Name = $"Generated {deviceType} Device";
                        }
                        
                        deviceInstances.Add(deviceType, device);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to instantiate {deviceType}: {ex.Message}");
                }
            }
            
            return deviceInstances;
        }
        
        private static void DisplayDeviceInstances(Dictionary<string, DeviceBase> deviceInstances)
        {
            Console.WriteLine("\n\nInstantiated Device Objects:");
            
            foreach (var (deviceType, device) in deviceInstances)
            {
                Console.WriteLine($"\n{device.Name} ({deviceType})");
                Console.WriteLine($"Device Type from object: {device.DeviceType}");
                Console.WriteLine($"Description: {device.Description}");
                
                DisplaySpecificDeviceProperties(device);
            }
        }
        
        private static void DisplaySpecificDeviceProperties(DeviceBase device)
        {
            // Display additional info based on device type
            switch (device)
            {
                case AreaBlockingDevice areaBlockingDevice:
                    Console.WriteLine($"Block Throwables: {areaBlockingDevice.BlockThrowables}");
                    Console.WriteLine($"Blue Effect: {areaBlockingDevice.BlueEffect}");
                    break;
                case PlayerStatusDevice playerStatusDevice:
                    Console.WriteLine($"Health: {playerStatusDevice.Health}");
                    Console.WriteLine($"Max Health: {playerStatusDevice.MaxHealth}");
                    break;
                case TriggerAreaDevice triggerAreaDevice:
                    Console.WriteLine($"Area Shape: {triggerAreaDevice.AreaShape}");
                    Console.WriteLine($"Area Color: {triggerAreaDevice.AreaColor}");
                    break;
                default:
                    DisplayInterfaceProperties(device);
                    break;
            }
        }
        
        private static void DisplayInterfaceProperties(DeviceBase device)
        {
            if (device is ITargetable targetableDevice)
            {
                Console.WriteLine($"Target: {targetableDevice.Target}");
            }
            
            if (device is IActivatable activatableDevice)
            {
                Console.WriteLine($"Activation Phase: {activatableDevice.ActivationPhase}");
            }
        }
        
        private static void HandleException(Exception ex, string filePath)
        {
            Console.WriteLine($"Error: {ex.Message}");
            
            if (ex is JsonException jsonEx)
            {
                Console.WriteLine($"JSON Error: {jsonEx.Message}");
            }
            else if (ex is FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
        }
    }
}
