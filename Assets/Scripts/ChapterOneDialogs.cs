using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterOneDialogs : MonoBehaviour {

    //Dialogs of Fox Mum
    public static List<Dialog> FOX_MUM_1;

    private void Start()
    {
        FOX_MUM_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Ist heute nicht ein schöner Tag?"),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Es ist noch zu früh um solche Vermutungen aufzustellen..."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Ich gehe jetzt zur Schule. Machs gut Mum."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Mein Sohn, bevor du zur Schule gehst nimm bitte diesen Einkaufszettel mit und besorge später diese Sachen."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Nagut... Ich bringe die Sachen mit."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Ich will später Kirschsouffle mit Zwetschgentampf machen."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Oh jaaaa, lecker!!")
                                        };
    }
}

