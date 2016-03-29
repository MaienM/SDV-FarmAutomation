﻿using FarmAutomation.Common;

namespace FarmAutomation.ItemCollector
{
    public class ItemCollectorConfiguration : ConfigurationBase
    {

        public bool PetAnimals { get; set; }
        public int AdditionalFriendshipFromCollecting { get; set; }

        public string MachinesToCollectFrom { get; set; }
        public string ItemsToConsiderConnectors { get; set; }
        public string LocationsToSearch { get; set; }
        public bool AddBuildingsToLocations { get; set; }

        public override void InitializeDefaults()
        {
            PetAnimals = true;
            AdditionalFriendshipFromCollecting = 5;
            EnableMod = true;
            MachinesToCollectFrom = "Keg, Preserves Jar, Cheese Press, Mayonnaise Machine, Loom, Oil Maker, Recycling Machine, Crystalarium, Worm Bin, Bee House, Strange Capsule, Tapper";
            ItemsToConsiderConnectors = "Keg, Preserves Jar, Cheese Press, Mayonnaise Machine, Loom, Oil Maker, Recycling Machine, Crystalarium, Worm Bin, Bee House, Strange Capsule, Tapper, Chest";
            LocationsToSearch = "Farm, Greenhouse, FarmHouse, FarmCave";
            AddBuildingsToLocations = true;
        }
    }
}