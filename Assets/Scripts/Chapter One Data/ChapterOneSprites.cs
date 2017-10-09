using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterOneSprites : MonoBehaviour {

    public static Sprite FOX_SON_HEAD;
    public static Sprite FOX_DAUGHTER_HEAD;
    public static Sprite FOX_MUM_HEAD;
    public static Sprite DEER_DAD_HEAD;
    public static Sprite DEER_MUM_HEAD;
    public static Sprite DEER_SON_HEAD;
    public static Sprite DEER_DAUGHTER_HEAD;
    public static Sprite OWL_HEAD;
    public static Sprite STORK_HEAD;
    public static Sprite CHIPMUNK_HEAD;
    public static Sprite BOY_HEAD;

    private void Start()
    {
        FOX_SON_HEAD = Resources.Load<Sprite>("Heads/Fuchs_Kopf_Junge");
        FOX_DAUGHTER_HEAD = Resources.Load<Sprite>("Heads/Fuchs_Kopf_Maedchen");
        FOX_MUM_HEAD = Resources.Load<Sprite>("Heads/Fuchs_Kopf_Mama");
        DEER_DAD_HEAD = Resources.Load<Sprite>("Heads/Reh_Kopf_Papa_rechtsblick");
        DEER_MUM_HEAD = Resources.Load<Sprite>("Heads/Reh_Kopf_Mama_rechtsblick");
        DEER_SON_HEAD = Resources.Load<Sprite>("Heads/Reh_Kopf_Junge_rechtsblick");
        DEER_DAUGHTER_HEAD = Resources.Load<Sprite>("Heads/Reh_Kopf_Maedchen_rechtsblick");
        OWL_HEAD = Resources.Load<Sprite>("Heads/eule_kopf");
        STORK_HEAD = Resources.Load<Sprite>("Heads/Poststorch_Kopf");
        CHIPMUNK_HEAD = Resources.Load<Sprite>("Heads/Streifenhoernchen_Kopf");
        BOY_HEAD = Resources.Load<Sprite>("Heads/Junge_Kopf");
    }
}
