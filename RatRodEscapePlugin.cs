[
  { "targetClass": "Sons.Gameplay.GameSetupManager", "method": "GetStartingLocation", "override": "ForceCaveSpawn", "purpose": "Start player in cannibal cave instead of heli crash" },
  { "targetClass": "Sons.Items.ItemSpawner", "method": "SpawnDynamicItems", "override": "InjectMashupItems", "purpose": "Spawn JDM and CMS parts in mutant camps" },
  { "targetClass": "Sons.Vehicles.GolfCartDrive", "method": "Update", "override": "RatRodPhysics", "purpose": "Apply JDM drift physics and low clearance when car is fully assembled" }
]