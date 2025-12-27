using UnityEngine;

public class Skin : MonoBehaviour
{
    SkinChoose skinChoose;
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
    public GameObject Choose1;
    public GameObject Choose2;
    public GameObject Choose3;
    public GameObject Choose4;
    public GameObject Choose5;
    public GameObject Choose6;
    public GameObject Choose7;
    public GameObject Choose8;
    public GameObject Choose9;
    public GameObject Choose10;
    public GameObject Choose11;
    public GameObject Choose12;
    public GameObject Choose13;
    public GameObject Choose14;
    public GameObject Choose15;
    public GameObject Choose16;
    public GameObject Choose17;
    public GameObject Choose18;
    public GameObject Choose19;
    public GameObject Choose20;
    public GameObject Choose21;

    public void Start()
    {
        if (skinChoose.Skin == 1)
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
            Choose1.SetActive(true);
            Choose2.SetActive(false);
            Choose3.SetActive(false);
            Choose4.SetActive(false);
            Choose5.SetActive(false);
            Choose6.SetActive(false);
            Choose7.SetActive(false);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
            Choose10.SetActive(false);
            Choose11.SetActive(false);
            Choose12.SetActive(false);
            Choose13.SetActive(false);
            Choose14.SetActive(false);
            Choose15.SetActive(false);
            Choose16.SetActive(false);
            Choose17.SetActive(false);
            Choose18.SetActive(false);
            Choose19.SetActive(false);
            Choose20.SetActive(false);
            Choose21.SetActive(false);
        }
        else if (skinChoose.Skin == 2)
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
            Choose1.SetActive(false);
            Choose2.SetActive(true);
            Choose3.SetActive(false);
            Choose4.SetActive(false);
            Choose5.SetActive(false);
            Choose6.SetActive(false);
            Choose7.SetActive(false);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
            Choose10.SetActive(false);
            Choose11.SetActive(false);
            Choose12.SetActive(false);
            Choose13.SetActive(false);
            Choose14.SetActive(false);
            Choose15.SetActive(false);
            Choose16.SetActive(false);
            Choose17.SetActive(false);
            Choose18.SetActive(false);
            Choose19.SetActive(false);
            Choose20.SetActive(false);
            Choose21.SetActive(false);
        }
        else if (skinChoose.Skin == 3)
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
            Choose1.SetActive(false);
            Choose2.SetActive(false);
            Choose3.SetActive(true);
            Choose4.SetActive(false);
            Choose5.SetActive(false);
            Choose6.SetActive(false);
            Choose7.SetActive(false);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
            Choose10.SetActive(false);
            Choose11.SetActive(false);
            Choose12.SetActive(false);
            Choose13.SetActive(false);
            Choose14.SetActive(false);
            Choose15.SetActive(false);
            Choose16.SetActive(false);
            Choose17.SetActive(false);
            Choose18.SetActive(false);
            Choose19.SetActive(false);
            Choose20.SetActive(false);
            Choose21.SetActive(false);
        }
        else if (skinChoose.Face == 1)
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
            Choose1.SetActive(false);
            Choose2.SetActive(false);
            Choose3.SetActive(false);
            Choose4.SetActive(true);
            Choose5.SetActive(false);
            Choose6.SetActive(false);
            Choose7.SetActive(false);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
        }
        else if (skinChoose.Face == 2)
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
            Choose1.SetActive(false);
            Choose2.SetActive(false);
            Choose3.SetActive(false);
            Choose4.SetActive(false);
            Choose5.SetActive(true);
            Choose6.SetActive(false);
            Choose7.SetActive(false);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
        }
        else if (skinChoose.Face == 3)
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
            Choose1.SetActive(false);
            Choose2.SetActive(false);
            Choose3.SetActive(false);
            Choose4.SetActive(false);
            Choose5.SetActive(false);
            Choose6.SetActive(true);
            Choose7.SetActive(false);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
        }
        else if (skinChoose.Face == 4)
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
            Choose1.SetActive(false);
            Choose2.SetActive(false);
            Choose3.SetActive(false);
            Choose4.SetActive(false);
            Choose5.SetActive(false);
            Choose6.SetActive(false);
            Choose7.SetActive(true);
            Choose8.SetActive(false);
            Choose9.SetActive(false);
        }
        else if (skinChoose.Face == 5)
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
            Choose1.SetActive(false);
            Choose2.SetActive(false);
            Choose3.SetActive(false);
            Choose4.SetActive(false);
            Choose5.SetActive(false);
            Choose6.SetActive(false);
            Choose7.SetActive(false);
            Choose8.SetActive(true);
            Choose9.SetActive(false);
        }
    }
}
