﻿using System.Collections;
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

    private void Start()
    {
        FOX_SON_HEAD = Resources.Load<Sprite>("");
        FOX_DAUGHTER_HEAD = Resources.Load<Sprite>("");
        FOX_MUM_HEAD = Resources.Load<Sprite>("");
        DEER_DAD_HEAD = Resources.Load<Sprite>("Reh_Kopf_Papa_rechtsblick");
        DEER_MUM_HEAD = Resources.Load<Sprite>("Reh_Kopf_Mama_rechtsblick");
        DEER_SON_HEAD = Resources.Load<Sprite>("Reh_Kopf_Junge_rechtsblick");
        DEER_DAUGHTER_HEAD = Resources.Load<Sprite>("Reh_Kopf_Maedchen_rechtsblick");
    }
}