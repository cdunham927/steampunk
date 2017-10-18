using UnityEngine;
using System.Collections;
using UnityEditor;

public class SpriteProcessor : AssetPostprocessor
{
    //called after a texture is loaded into the editor
    void OnPostprocessTexture(Texture2D texture)
    {
        //makes all paths we check lowercase(easier to check)
        string lowerCaseAssetPath = assetPath.ToLower();
        //check if whatevers loaded in is going to the right folder
        bool isInSpritesDirectory = lowerCaseAssetPath.IndexOf("/sprites/") != -1;

        //if its in the right folder, convert it to a sprite
        //then change 'generate mip maps' to false
        //then set the filter mode to point
        //then the format to truecolor
        if (isInSpritesDirectory)
        {
            TextureImporter textureImporter = (TextureImporter) assetImporter;
            textureImporter.textureType = TextureImporterType.Sprite;
            textureImporter.mipmapEnabled = false;
            textureImporter.filterMode = FilterMode.Point;
            textureImporter.textureFormat = TextureImporterFormat.AutomaticTruecolor;
        }
    }
}
