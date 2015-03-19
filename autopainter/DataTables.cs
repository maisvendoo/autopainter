//-------------------------------------------------------------------
//
//      Data tables structures
//      (c) maisvendoo, 2015/03/17
//
//-------------------------------------------------------------------

public struct TModelColor
{
    public string id;
    public string packageId;
    public string carFactoryId;
    public string stockColor;
    public string colorName;
    public string colorId;
    public string colorFamily;
    public string refPhotoPath;
    public string matchModel;
}

public struct TCarFactory
{
    public string id;
    public string packageId;
    public string name;
    public string nbr;
    public string shortName;
    public string englishName;
}