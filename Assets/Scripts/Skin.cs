using UnityEngine;

public class Skin : MonoBehaviour
{
    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject Skin3;
    public GameObject Face1;
    public GameObject Face2;
    public GameObject Face3;
    public GameObject Face4;
    public GameObject Face5;
    public GameObject Face6;
    public GameObject Inside1;
    public GameObject Inside2;
    public GameObject Inside3;
    public GameObject Inside4;
    public GameObject Inside5;
    public GameObject Inside6;
    public GameObject Frame1;
    public GameObject Frame2;
    public GameObject Frame3;
    public GameObject Frame4;
    public GameObject Frame5;
    public GameObject Frame6;

    public void Start()
    {
        if (SkinChoose.Skin == 1)
        {
            Skin1.SetActive(true);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Skin == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(true);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Skin == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(true);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Face == 1)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(true);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(false);
        }
        else if (SkinChoose.Face == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(true);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(false);
        }
        else if (SkinChoose.Face == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(true);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(false);
        }
        else if (SkinChoose.Face == 4)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(true);
            Face5.SetActive(false);
            Face6.SetActive(false);
        }
        else if (SkinChoose.Face == 5)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(true);
            Face6.SetActive(false);
        }
        else if (SkinChoose.Face == 6)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Face1.SetActive(false);
            Face2.SetActive(false);
            Face3.SetActive(false);
            Face4.SetActive(false);
            Face5.SetActive(false);
            Face6.SetActive(true);
        }
        else if (SkinChoose.Inside == 1)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Inside1.SetActive(true);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
        }
        else if (SkinChoose.Inside == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(true);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
        }
        else if (SkinChoose.Inside == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(true);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
        }
        else if (SkinChoose.Inside == 4)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(true);
            Inside5.SetActive(false);
            Inside6.SetActive(false);
        }
        else if (SkinChoose.Inside == 5)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(true);
            Inside6.SetActive(false);
        }
        else if (SkinChoose.Inside == 6)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Inside1.SetActive(false);
            Inside2.SetActive(false);
            Inside3.SetActive(false);
            Inside4.SetActive(false);
            Inside5.SetActive(false);
            Inside6.SetActive(true);
        }
        else if (SkinChoose.Frame == 1)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Frame1.SetActive(true);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Frame == 2)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(true);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Frame == 3)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(true);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Frame == 4)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(true);
            Frame5.SetActive(false);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Frame == 5)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(true);
            Frame6.SetActive(false);
        }
        else if (SkinChoose.Frame == 6)
        {
            Skin1.SetActive(false);
            Skin2.SetActive(false);
            Skin3.SetActive(false);
            Frame1.SetActive(false);
            Frame2.SetActive(false);
            Frame3.SetActive(false);
            Frame4.SetActive(false);
            Frame5.SetActive(false);
            Frame6.SetActive(true);
        }
    }
}
