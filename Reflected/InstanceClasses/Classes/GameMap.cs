namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GameMap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameMapR:InstanceClassWrapper<GameMap>
{
public GameMapR(GameMap _orig) : base(_orig) {}
public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}

public UnityEngine.GameObject hero
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public InputHandler inputHandler
{
get => GetField<InputHandler>();
set => SetField(value);
}

public UnityEngine.GameObject compassIcon
{
get => orig.compassIcon;
set => orig.compassIcon = value;
}

public float originOffsetX
{
get => GetField<float>();
set => SetField(value);
}

public float originOffsetY
{
get => GetField<float>();
set => SetField(value);
}

public float sceneWidth
{
get => GetField<float>();
set => SetField(value);
}

public float sceneHeight
{
get => GetField<float>();
set => SetField(value);
}

public float doorX
{
get => orig.doorX;
set => orig.doorX = value;
}

public float doorY
{
get => orig.doorY;
set => orig.doorY = value;
}

public string doorScene
{
get => orig.doorScene;
set => orig.doorScene = value;
}

public string doorMapZone
{
get => orig.doorMapZone;
set => orig.doorMapZone = value;
}

public float doorOriginOffsetX
{
get => orig.doorOriginOffsetX;
set => orig.doorOriginOffsetX = value;
}

public float doorOriginOffsetY
{
get => orig.doorOriginOffsetY;
set => orig.doorOriginOffsetY = value;
}

public float doorSceneWidth
{
get => orig.doorSceneWidth;
set => orig.doorSceneWidth = value;
}

public float doorSceneHeight
{
get => orig.doorSceneHeight;
set => orig.doorSceneHeight = value;
}

public bool inRoom
{
get => orig.inRoom;
set => orig.inRoom = value;
}

public UnityEngine.GameObject areaAncientBasin
{
get => orig.areaAncientBasin;
set => orig.areaAncientBasin = value;
}

public UnityEngine.GameObject areaCity
{
get => orig.areaCity;
set => orig.areaCity = value;
}

public UnityEngine.GameObject areaCliffs
{
get => orig.areaCliffs;
set => orig.areaCliffs = value;
}

public UnityEngine.GameObject areaCrossroads
{
get => orig.areaCrossroads;
set => orig.areaCrossroads = value;
}

public UnityEngine.GameObject areaCrystalPeak
{
get => orig.areaCrystalPeak;
set => orig.areaCrystalPeak = value;
}

public UnityEngine.GameObject areaDeepnest
{
get => orig.areaDeepnest;
set => orig.areaDeepnest = value;
}

public UnityEngine.GameObject areaFogCanyon
{
get => orig.areaFogCanyon;
set => orig.areaFogCanyon = value;
}

public UnityEngine.GameObject areaFungalWastes
{
get => orig.areaFungalWastes;
set => orig.areaFungalWastes = value;
}

public UnityEngine.GameObject areaGreenpath
{
get => orig.areaGreenpath;
set => orig.areaGreenpath = value;
}

public UnityEngine.GameObject areaKingdomsEdge
{
get => orig.areaKingdomsEdge;
set => orig.areaKingdomsEdge = value;
}

public UnityEngine.GameObject areaQueensGardens
{
get => orig.areaQueensGardens;
set => orig.areaQueensGardens = value;
}

public UnityEngine.GameObject areaRestingGrounds
{
get => orig.areaRestingGrounds;
set => orig.areaRestingGrounds = value;
}

public UnityEngine.GameObject areaDirtmouth
{
get => orig.areaDirtmouth;
set => orig.areaDirtmouth = value;
}

public UnityEngine.GameObject areaWaterways
{
get => orig.areaWaterways;
set => orig.areaWaterways = value;
}

public UnityEngine.GameObject flamePins
{
get => orig.flamePins;
set => orig.flamePins = value;
}

public UnityEngine.GameObject dreamerPins
{
get => orig.dreamerPins;
set => orig.dreamerPins = value;
}

public UnityEngine.GameObject shadeMarker
{
get => orig.shadeMarker;
set => orig.shadeMarker = value;
}

public UnityEngine.GameObject dreamGateMarker
{
get => orig.dreamGateMarker;
set => orig.dreamGateMarker = value;
}

public bool posGate
{
get => GetField<bool>();
set => SetField(value);
}

public bool displayNextArea
{
get => orig.displayNextArea;
set => orig.displayNextArea = value;
}

public bool displayingCompass
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Vector3 currentScenePos
{
get => orig.currentScenePos;
set => orig.currentScenePos = value;
}

public UnityEngine.GameObject currentScene
{
get => orig.currentScene;
set => orig.currentScene = value;
}

public bool canPan
{
get => orig.canPan;
set => orig.canPan = value;
}

public float panSpeed
{
get => orig.panSpeed;
set => orig.panSpeed = value;
}

public float panMinX
{
get => orig.panMinX;
set => orig.panMinX = value;
}

public float panMaxX
{
get => orig.panMaxX;
set => orig.panMaxX = value;
}

public float panMinY
{
get => orig.panMinY;
set => orig.panMinY = value;
}

public float panMaxY
{
get => orig.panMaxY;
set => orig.panMaxY = value;
}

public UnityEngine.GameObject panArrowU
{
get => orig.panArrowU;
set => orig.panArrowU = value;
}

public UnityEngine.GameObject panArrowD
{
get => orig.panArrowD;
set => orig.panArrowD = value;
}

public UnityEngine.GameObject panArrowL
{
get => orig.panArrowL;
set => orig.panArrowL = value;
}

public UnityEngine.GameObject panArrowR
{
get => orig.panArrowR;
set => orig.panArrowR = value;
}

public UnityEngine.GameObject[] mapMarkersBlue
{
get => orig.mapMarkersBlue;
set => orig.mapMarkersBlue = value;
}

public UnityEngine.GameObject[] mapMarkersRed
{
get => orig.mapMarkersRed;
set => orig.mapMarkersRed = value;
}

public UnityEngine.GameObject[] mapMarkersYellow
{
get => orig.mapMarkersYellow;
set => orig.mapMarkersYellow = value;
}

public UnityEngine.GameObject[] mapMarkersWhite
{
get => orig.mapMarkersWhite;
set => orig.mapMarkersWhite = value;
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Start () =>
CallMethod();

public void LevelReady () =>
orig.LevelReady();

public void OnLevelWasLoaded () =>
CallMethod();

public void SetCompassPoint () =>
orig.SetCompassPoint();

public void GetDoorValues () =>
orig.GetDoorValues();

public void SetupMap (bool pinsOnly = false) =>
orig.SetupMap(pinsOnly);

public void GetTilemapDimensions () =>
CallMethod();

public void WorldMap () =>
orig.WorldMap();

public void QuickMapAncientBasin () =>
orig.QuickMapAncientBasin();

public void QuickMapCity () =>
orig.QuickMapCity();

public void QuickMapCliffs () =>
orig.QuickMapCliffs();

public void QuickMapCrossroads () =>
orig.QuickMapCrossroads();

public void QuickMapCrystalPeak () =>
orig.QuickMapCrystalPeak();

public void QuickMapDeepnest () =>
orig.QuickMapDeepnest();

public void QuickMapFogCanyon () =>
orig.QuickMapFogCanyon();

public void QuickMapFungalWastes () =>
orig.QuickMapFungalWastes();

public void QuickMapGreenpath () =>
orig.QuickMapGreenpath();

public void QuickMapKingdomsEdge () =>
orig.QuickMapKingdomsEdge();

public void QuickMapQueensGardens () =>
orig.QuickMapQueensGardens();

public void QuickMapRestingGrounds () =>
orig.QuickMapRestingGrounds();

public void QuickMapDirtmouth () =>
orig.QuickMapDirtmouth();

public void QuickMapWaterways () =>
orig.QuickMapWaterways();

public void CloseQuickMap () =>
orig.CloseQuickMap();

public void PositionDreamGateMarker () =>
orig.PositionDreamGateMarker();

public void PositionCompass (bool posShade) =>
orig.PositionCompass(posShade);

public void Update () =>
CallMethod();

public void DisableMarkers () =>
CallMethod();

public void SetManualTilemap (float offsetX, float offsetY, float width, float height) =>
orig.SetManualTilemap(offsetX, offsetY, width, height);

public void SetDoorValues (float x, float y, string scene, string mapZone) =>
orig.SetDoorValues(x, y, scene, mapZone);

public void SetCustomCompassPos (float x, float y, string scene, string mapZone, float offsetX, float offsetY, float width, float height) =>
orig.SetCustomCompassPos(x, y, scene, mapZone, offsetX, offsetY, width, height);

public void SetInRoom (bool room) =>
orig.SetInRoom(room);

public void SetCanPan (bool pan) =>
orig.SetCanPan(pan);

public string GetDoorMapZone () =>
orig.GetDoorMapZone();

public bool GetInRoom () =>
orig.GetInRoom();

public void SetPanArrows (UnityEngine.GameObject arrowU, UnityEngine.GameObject arrowD, UnityEngine.GameObject arrowL, UnityEngine.GameObject arrowR) =>
orig.SetPanArrows(arrowU, arrowD, arrowL, arrowR);

public void KeepWithinBounds () =>
orig.KeepWithinBounds();

public void StopPan () =>
orig.StopPan();

public void StartPan () =>
orig.StartPan();

public void SetupMapMarkers () =>
orig.SetupMapMarkers();

}
}
