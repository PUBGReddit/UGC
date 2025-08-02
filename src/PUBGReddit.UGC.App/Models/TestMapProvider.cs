using System;
using System.Collections.Generic;

namespace PUBGReddit.UGC.App.Models
{
    public static class TestMapProvider
    {
        public static List<Map> GetTestMaps()
        {
            return new List<Map>
            {
                new Map
                {
                    Name = "Wild Wild West",
                    LastChangeDate = new DateOnly(2025, 8, 1),
                    Author = "Delzaugh & Xenny",
                    ImageUrl = "https://wstatic-prod-boc.krafton.com/common/news/20250706/wiHRyHrX.jpg",
                    Description = "A thrilling desert map with unique challenges.",
                    MapUrl = "https://github.com/PUBGReddit/UGC/raw/main/maps_gallery/WildWest/WILD_WEST_Draft.pugc",
                    Tags = "GunMode, TDM, One-In-The-Chamber"
                },   new Map
                {
                    Name = "Desert Arena",
                    LastChangeDate = new DateOnly(2025, 8, 1),
                    Author = "John Doe",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "A thrilling desert map with unique challenges.",
                    MapUrl = "https://example.com/desert-map",
                    Tags = "Adventure,Battle"
                },
                new Map
                {
                    Name = "Forest Escape",
                    LastChangeDate = new DateOnly(2025, 7, 30),
                    Author = "Jane Smith",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Navigate through dense forests and hidden paths.",
                    MapUrl = "https://example.com/forest-map",
                    Tags = "Survival,Strategy"
                },
                new Map
                {
                    Name = "Mountain Clash",
                    LastChangeDate = new DateOnly(2025, 7, 25),
                    Author = "Alice Brown",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the rugged mountain terrain.",
                    MapUrl = "https://example.com/mountain-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Urban Warfare",
                    LastChangeDate = new DateOnly(2025, 7, 20),
                    Author = "Bob White",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Fight in the heart of the city.",
                    MapUrl = "https://example.com/urban-map",
                    Tags = "Battle,Survival"
                },
                new Map
                {
                    Name = "Island Survival",
                    LastChangeDate = new DateOnly(2025, 7, 15),
                    Author = "Charlie Green",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive on a deserted island.",
                    MapUrl = "https://example.com/island-map",
                    Tags = "Survival,Adventure"
                },
                new Map
                {
                    Name = "Cave Exploration",
                    LastChangeDate = new DateOnly(2025, 7, 10),
                    Author = "Diana Black",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Explore the mysterious caves.",
                    MapUrl = "https://example.com/cave-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Frozen Tundra",
                    LastChangeDate = new DateOnly(2025, 7, 5),
                    Author = "Eve Blue",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the icy wilderness.",
                    MapUrl = "https://example.com/tundra-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Volcanic Showdown",
                    LastChangeDate = new DateOnly(2025, 7, 1),
                    Author = "Frank Red",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Fight near the erupting volcano.",
                    MapUrl = "https://example.com/volcano-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Jungle Trek",
                    LastChangeDate = new DateOnly(2025, 6, 25),
                    Author = "Grace Yellow",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Navigate through the dense jungle.",
                    MapUrl = "https://example.com/jungle-map",
                    Tags = "Adventure,Survival"
                },
                // Add 10 more maps here
                new Map
                {
                    Name = "Ocean Depths",
                    LastChangeDate = new DateOnly(2025, 6, 20),
                    Author = "Henry Aqua",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Explore the underwater world.",
                    MapUrl = "https://example.com/ocean-map",
                    Tags = "Adventure,Survival"
                },
                new Map
                {
                    Name = "Sky High",
                    LastChangeDate = new DateOnly(2025, 6, 15),
                    Author = "Ivy Cloud",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the skies.",
                    MapUrl = "https://example.com/sky-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Mystic Ruins",
                    LastChangeDate = new DateOnly(2025, 6, 10),
                    Author = "Jack Ancient",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover ancient secrets.",
                    MapUrl = "https://example.com/ruins-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Lava Fields",
                    LastChangeDate = new DateOnly(2025, 6, 5),
                    Author = "Karen Heat",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the scorching heat.",
                    MapUrl = "https://example.com/lava-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Crystal Caverns",
                    LastChangeDate = new DateOnly(2025, 6, 1),
                    Author = "Leo Shine",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Explore the sparkling caves.",
                    MapUrl = "https://example.com/crystal-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Dark Forest",
                    LastChangeDate = new DateOnly(2025, 5, 25),
                    Author = "Mia Shadow",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Navigate through the eerie woods.",
                    MapUrl = "https://example.com/darkforest-map",
                    Tags = "Survival,Adventure"
                },
                new Map
                {
                    Name = "Golden Plains",
                    LastChangeDate = new DateOnly(2025, 5, 20),
                    Author = "Nina Gold",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the golden fields.",
                    MapUrl = "https://example.com/plains-map",
                    Tags = "Battle,Strategy"
                },
                new Map
                {
                    Name = "Frozen Lake",
                    LastChangeDate = new DateOnly(2025, 5, 15),
                    Author = "Oscar Ice",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the icy waters.",
                    MapUrl = "https://example.com/lake-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Hidden Valley",
                    LastChangeDate = new DateOnly(2025, 5, 10),
                    Author = "Paul Secret",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover the hidden valley.",
                    MapUrl = "https://example.com/valley-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Stormy Peaks",
                    LastChangeDate = new DateOnly(2025, 5, 5),
                    Author = "Quinn Thunder",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the stormy mountains.",
                    MapUrl = "https://example.com/peaks-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Sunset Canyon",
                    LastChangeDate = new DateOnly(2025, 4, 30),
                    Author = "Anna Horizon",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Explore the beautiful canyon at sunset.",
                    MapUrl = "https://example.com/sunset-map",
                    Tags = "Adventure,Survival"
                },
                new Map
                {
                    Name = "Blazing Desert",
                    LastChangeDate = new DateOnly(2025, 4, 25),
                    Author = "Blake Sand",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the scorching desert heat.",
                    MapUrl = "https://example.com/blazing-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Emerald Forest",
                    LastChangeDate = new DateOnly(2025, 4, 20),
                    Author = "Cora Green",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Navigate through the lush emerald forest.",
                    MapUrl = "https://example.com/emerald-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Thunder Plains",
                    LastChangeDate = new DateOnly(2025, 4, 15),
                    Author = "Derek Storm",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the electrifying plains.",
                    MapUrl = "https://example.com/thunder-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Crystal Lagoon",
                    LastChangeDate = new DateOnly(2025, 4, 10),
                    Author = "Ella Shine",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Explore the sparkling lagoon.",
                    MapUrl = "https://example.com/lagoon-map",
                    Tags = "Adventure,Survival"
                },
                new Map
                {
                    Name = "Shadow Valley",
                    LastChangeDate = new DateOnly(2025, 4, 5),
                    Author = "Finn Dark",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover the secrets of the shadowy valley.",
                    MapUrl = "https://example.com/shadow-map",
                    Tags = "Survival,Strategy"
                },
                new Map
                {
                    Name = "Golden Coast",
                    LastChangeDate = new DateOnly(2025, 4, 1),
                    Author = "Grace Gold",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle along the golden coastline.",
                    MapUrl = "https://example.com/coast-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Frozen Peaks",
                    LastChangeDate = new DateOnly(2025, 3, 25),
                    Author = "Hank Ice",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the icy mountain peaks.",
                    MapUrl = "https://example.com/peaks-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Hidden Caverns",
                    LastChangeDate = new DateOnly(2025, 3, 20),
                    Author = "Ivy Secret",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Explore the mysterious hidden caverns.",
                    MapUrl = "https://example.com/caverns-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Stormy Hills",
                    LastChangeDate = new DateOnly(2025, 3, 15),
                    Author = "Jack Thunder",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the stormy hills.",
                    MapUrl = "https://example.com/hills-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Mystic Lake",
                    LastChangeDate = new DateOnly(2025, 3, 10),
                    Author = "Karen Mystic",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover the secrets of the mystic lake.",
                    MapUrl = "https://example.com/mystic-map",
                    Tags = "Adventure,Survival"
                },
                new Map
                {
                    Name = "Dark Canyon",
                    LastChangeDate = new DateOnly(2025, 3, 5),
                    Author = "Leo Shadow",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Navigate through the eerie canyon.",
                    MapUrl = "https://example.com/dark-map",
                    Tags = "Survival,Strategy"
                },
                new Map
                {
                    Name = "Golden Fields",
                    LastChangeDate = new DateOnly(2025, 3, 1),
                    Author = "Mia Gold",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the golden fields.",
                    MapUrl = "https://example.com/fields-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Frozen River",
                    LastChangeDate = new DateOnly(2025, 2, 25),
                    Author = "Oscar Ice",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the icy river.",
                    MapUrl = "https://example.com/river-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Hidden Forest",
                    LastChangeDate = new DateOnly(2025, 2, 20),
                    Author = "Paul Secret",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover the hidden forest.",
                    MapUrl = "https://example.com/forest-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Stormy Valley",
                    LastChangeDate = new DateOnly(2025, 2, 15),
                    Author = "Quinn Thunder",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the stormy valley.",
                    MapUrl = "https://example.com/valley-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Mystic Canyon",
                    LastChangeDate = new DateOnly(2025, 2, 10),
                    Author = "Riley Mystic",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover the secrets of the mystic canyon.",
                    MapUrl = "https://example.com/mystic-map",
                    Tags = "Adventure,Survival"
                },
                new Map
                {
                    Name = "Dark Lagoon",
                    LastChangeDate = new DateOnly(2025, 2, 5),
                    Author = "Sam Shadow",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Navigate through the eerie lagoon.",
                    MapUrl = "https://example.com/dark-map",
                    Tags = "Survival,Strategy"
                },
                new Map
                {
                    Name = "Golden Canyon",
                    LastChangeDate = new DateOnly(2025, 2, 1),
                    Author = "Tina Gold",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the golden canyon.",
                    MapUrl = "https://example.com/canyon-map",
                    Tags = "Battle,Adventure"
                },
                new Map
                {
                    Name = "Frozen Lagoon",
                    LastChangeDate = new DateOnly(2025, 1, 25),
                    Author = "Uma Ice",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Survive the icy lagoon.",
                    MapUrl = "https://example.com/lagoon-map",
                    Tags = "Survival,Battle"
                },
                new Map
                {
                    Name = "Hidden Canyon",
                    LastChangeDate = new DateOnly(2025, 1, 20),
                    Author = "Victor Secret",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Discover the hidden canyon.",
                    MapUrl = "https://example.com/canyon-map",
                    Tags = "Adventure,Strategy"
                },
                new Map
                {
                    Name = "Stormy Lagoon",
                    LastChangeDate = new DateOnly(2025, 1, 15),
                    Author = "Will Thunder",
                    ImageUrl = "https://picsum.photos/1920/1080",
                    Description = "Battle in the stormy lagoon.",
                    MapUrl = "https://example.com/lagoon-map",
                    Tags = "Battle,Adventure"
                }
            };
        }
    }
}
