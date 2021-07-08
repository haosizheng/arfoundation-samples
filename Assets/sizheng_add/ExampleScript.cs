using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    public Cubemap cubemap;
    public void Start()
    {
        cubemap = new Cubemap(2, TextureFormat.RGB24, true);

        var byteArray = new byte[] {255, 0, 0,
                                    0, 255, 0,
                                    0, 0, 255,
                                    255, 235, 4,
                                    255, 0, 255,
                                    255, 255, 255,
                                    0, 0, 0,
                                    0, 255, 255,
                                    255, 0, 255};

        cubemap.SetPixelData(byteArray, 0, CubemapFace.PositiveX);
        //cubemap.SetPixelData(byteArray, 1, CubemapFace.PositiveX, 12);

        cubemap.SetPixelData(byteArray, 0, CubemapFace.NegativeX, 15);
        //cubemap.SetPixelData(byteArray, 1, CubemapFace.NegativeX, 12);

        cubemap.SetPixelData(byteArray, 0, CubemapFace.PositiveY);
        //cubemap.SetPixelData(byteArray, 1, CubemapFace.PositiveY, 12);

        cubemap.SetPixelData(byteArray, 0, CubemapFace.NegativeY, 15);
        //cubemap.SetPixelData(byteArray, 1, CubemapFace.NegativeY, 12);

        cubemap.SetPixelData(byteArray, 0, CubemapFace.PositiveZ);
        //cubemap.SetPixelData(byteArray, 1, CubemapFace.PositiveZ, 12);

        cubemap.SetPixelData(byteArray, 0, CubemapFace.NegativeZ, 15);
        //cubemap.SetPixelData(byteArray, 1, CubemapFace.NegativeZ, 12);

        cubemap.Apply(updateMipmaps: false);
    }
}