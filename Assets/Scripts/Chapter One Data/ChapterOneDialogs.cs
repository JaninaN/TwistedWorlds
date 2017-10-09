using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterOneDialogs : MonoBehaviour {

    //Dialogs of Fox Mum
    public static List<Dialog> FOX_MUM_1;
    public static List<Dialog> FOX_MUM_2;
    public static List<Dialog> FOX_MUM_3;
    public static List<Dialog> FOX_MUM_4;
    //Dialogs of Deer Mum
    public static List<Dialog> DEER_MUM_1;
    public static List<Dialog> DEER_MUM_2;
    public static List<Dialog> DEER_MUM_3;
    //Dialogs of Owl
    public static List<Dialog> OWL_1;
    public static List<Dialog> OWL_2;
    public static List<Dialog> OWL_3;
    public static List<Dialog> OWL_4;
    //Dialogs of Deer Son
    public static List<Dialog> DEER_SON_1;
    public static List<Dialog> DEER_SON_2;
    public static List<Dialog> DEER_SON_3;
    //Dialogs of Deer Daughter
    public static List<Dialog> DEER_DAUGHTER_1;
    public static List<Dialog> DEER_DAUGHTER_2;
    //Dialogs of Fox Daughter
    public static List<Dialog> FOX_DAUGHTER_1;
    public static List<Dialog> FOX_DAUGHTER_2;
    public static List<Dialog> FOX_DAUGHTER_3;
    //Dialogs of Stork
    public static List<Dialog> STORK_1;
    public static List<Dialog> STORK_2;
    public static List<Dialog> STORK_3;
    //Dialogs of Chipmunk
    public static List<Dialog> CHIPMUNK_1;
    public static List<Dialog> CHIPMUNK_2;
    public static List<Dialog> CHIPMUNK_3;

    //Storyline Dialogs
    public static List<string> FIRST_RIDDLE_BEGINNING;
    public static List<string> FIRST_RIDDLE_DESTROY_BOX;
    public static List<string> FIRST_RIDDLE_AMULET_COLLECTED;

    //Possible Answers
    public static string RIDDLE_ONE_YES = "Ich versuche mal das Rätsel zu lösen...";
    public static string RIDDLE_ONE_NO = "Komisches Teil. Was solls, ich mache es kaputt! Das geht schneller.";

    private void Start()
    {
        FOX_MUM_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Da bist du ja mein Sohn. Hast du alles vom Markt besorgt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nein noch nicht. Die Äpfel fehlen noch."),
                                        new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Dann geh bitte nochmal zurück und hole welche."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok, bis später.")
                                        };
        FOX_MUM_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Da bist du ja mein Sohn. Hast du alles vom Markt besorgt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja, hier schau."),
                                        new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Das hast du gut gemacht. Ich hätte nur noch eine Bitte an dich."),
                                        new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Sei so lieb und bringe die Äpfel zur alten Eule im Wald. Sie freut sich sicher über Besuch."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Aber Mama, die ist unheimlich... manchmal redet sie wirres Zeug."),
                                        new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Sei nicht so hart mit Ihr, Sie ist schließlich schon sehr alt und meist alleine."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok ich gehe zu Ihr..."),
                                        };
        FOX_MUM_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Warst du schon bei der alten Eule?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nein, noch nicht."),
                                        new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Dann geh jetzt besser, bevor es dunkel wird.")
                                        };
        FOX_MUM_4 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Warst du bei der alten Eule?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja und ich hab unterwegs ein magisches Amulett gefunden mit dem ich zwischen den Dimensionen reisen kann und dann die Welt retten muss."),
                                        new Dialog(ChapterOneSprites.FOX_MUM_HEAD, "Das klingt ja mal spannend. Dann geh du mal die Welt retten, aber mach keinen Ärger und sieh zu dass du zum Abendessen pünktlich zuhause bist!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok Ma!")
                                        };
        DEER_MUM_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Hallo Füchschen, wie läuft es in der Schule?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ganz gut. Wir nehmen gerade das große Märchen von den Menschen durch."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ich habe es auch in mein Notizbuch geschrieben, dann klappt das auswendig lernen gleich viel besser!"),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Das ist eine gute Idee. Was kann ich dir denn gutes tun?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Meine Mum schickt mich, ich soll Äpfel kaufen."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "In Ordnung, nimm dir ruhig von den Äpfeln. Ich verrechne sie dann mit deiner Mum."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Vielen Dank.")
                                        };
        DEER_MUM_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Ich hoffe ihr seid mit meiner Ware zufrieden.")
                                        };
        DEER_MUM_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "War deine Mutter mit dem Einkauf zufrieden?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja und jetzt muss ich die Welt retten gehen."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Tu das Füchschen... tu das...")
                                        };
        OWL_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Guten Tag Frau Eule meine Mutter schickt mich. Ich bringe Ihnen Äpfel."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Oh! Guten Tag Füchschen. Das ist aber lieb von …"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Füchschen woher hast du dieses Amulett?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Es ist eben erschienen, ich hab keine Ahnung was das für ein Ding ist…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "… Du bist der Auserwählte!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "WAS?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du wurdest auserwählt um unsere Welt vor dem Untergang zu bewahren"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Wovon reden Sie?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Prophezeiung!!!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Na toll… Auserwählter, Weltuntergang, Prophezeiung? In was für nem Spiel bin ich hier gelandet?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Welt steht kurz vor dem Untergang und die Person, die von dem Amulett auserwählt wird, ist die einzige, die diese Welt vor dem Untergang noch retten kann."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du bist der Einzige der in der Lage ist das Amulett zu benutzen. Es ist deine Aufgabe Füchschen!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Wenn du es nicht tust wird die Welt, wie wir sie kennen, enden"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du bist der Auserwählte! Nur du allein – Sag mal hörst du mir eigentlich zu?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ehm, ja… sagen Sie mir einfach was ich tun soll, damit ich das gleich hinter mich bringen kann. Auf mich wartet zu Hause noch ein neues Spiel… Also was soll ich machen?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Kinder von Heute…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Dieses Amulett hat die Kraft Türen in eine andere Welt zu öffnen. Du musst diese Welt bereisen und herausfinden was für den bevorstehenden Untergang verantwortlich ist und es aufhalten!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "ah okay... dann mach ich mich mal auf den Weg."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Gut wenn du noch Fragen hast weist du ja wo du mich findest")
                                        };
        OWL_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Guten Tag Frau Eule meine Mutter schickt mich. Ich bringe Ihnen Äpfel."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Oh! Guten Tag Füchschen. Das ist aber lieb von…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Füchschen woher hast du dieses Amulett und warum ist es kaputt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Es ist eben in so einer Schatulle erschienen und ich hab die Schatulle kaputt getreten. Bestimmt war das Amulett schon vorher kaputt…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Weißt du überhaupt was du angerichtet hast?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nee… ich weiß nur, dass es Konsequenzen haben wird…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du bist der Auserwählte der die Welt vor dem Untergang retten sollte und das Einzige was dir dabei helfen konnte war dieses Amulett!"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Welt ist nun endgültig verloren! Nichts und Niemand kann uns jetzt noch helfen!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Okay. Ich geh dann mal nach Hause… da wartet noch ein Spiel auf mich…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Alles ist verloren…")
                                        };
        OWL_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.OWL_HEAD, "Du hast Fragen? "),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja... Was soll ich jetzt noch mal machen?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "An deinem Rucksack befindet sich das Amulett, berühre es und du wirst die Kraft erhalten zwischen den Dimensionen zu reisen."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Reise in die andere Dimension um herauszufinden was für den bevorstehenden Untergang verantwortlich ist und halte es auf!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok. Ich glaub ich hab's verstanden.")
                                        };
        OWL_4 = new List<Dialog>() { new Dialog(ChapterOneSprites.OWL_HEAD, "Es ist vorbei … die Demo auch…")
                                        };
        DEER_SON_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Hey Fuchs! Hast du Lust gleich mit Fußball zu spielen?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Hey Reh! Ich muss erst zum Markt. Meine Mum wollte, dass ich noch Einkäufe erledige und Heim bringe. Aber vielleicht danach."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Ok, du weist ja wo du uns findest. Viel Spaß beim shoppen."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja, danke... man sieht sich."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Bis dann.")
                                        };
        DEER_SON_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Solltest du nicht noch was erledigen?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja schon...."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Worauf wartest du dann noch? Je schneller du fertig bist, desto schneller kannst du mitspielen.")
                                        };
        DEER_SON_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Na? Alles erledigt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nee, muss nur noch kurz die Welt retten. Danach komm ich wieder."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Aha... ja ok... tu das...")
                                        };
        DEER_DAUGHTER_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_DAUGHTER_HEAD, "Hallo Fuchs! Na magst du mitspielen?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Hallo Reh! Nee du ich hab noch paar Sachen zu erledigen... aber sag mal bist du nicht schon zu alt für Hüpfekästchen?"),
                                        new Dialog(ChapterOneSprites.DEER_DAUGHTER_HEAD, "MAN IST NIE ZU ALT FÜR HÜPFEKÄSTCHEN!!!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok... ich lass dich dann mal alleine....")
                                        };
        DEER_DAUGHTER_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_DAUGHTER_HEAD, "NIEMALS!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja ist ja schon gut....")
                                        };
        FOX_DAUGHTER_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Hi Bruderherz! Du weist noch, dass Mama wollte, dass du direkt nach der Schule zum Markt Äpfel kaufen gehst oder?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja ich weiß... kannst du das nicht für mich erledigen? Ich hab schon soooo viel zu tun...."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Nee, sorry. Ich hab Reh versprochen, dass wir was unternehmen. Außerdem weiß ich ganz genau, dass du nur schnell nachhause willst um dein neues Spiel zu zocken...."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Was? Ich doch nicht. Na ja, dann mach ich mich mal auf den Weg... bis dann."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Ok, bis dann Bruderherz.")
                                        };
        FOX_DAUGHTER_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Na schon alles erledigt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nee, noch nicht...."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Worauf wartest du dann noch? Los! Hopp Hopp!")
                                        };
        FOX_DAUGHTER_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Hey! Du hast schon alles erledigt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja, aber ich muss jetzt auch noch die Welt retten..."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Das neue Spiel hat dir schon zugesetzt was? Vielleicht solltest du weniger zocken...")
                                        };
        STORK_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.STORK_HEAD, "Hallo junger Fuchs, wie kann ich dir helfen?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Hallo Herr Storch! Eigentlich gar nicht mehr..."),
                                        new Dialog(ChapterOneSprites.STORK_HEAD, "Hahaha! Die Jugend von heute, immer so sarkastisch."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Schlimm oder?"),
                                        new Dialog(ChapterOneSprites.STORK_HEAD, "Hahaha!")
                                        };
        STORK_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.STORK_HEAD, "Na? Ist dir vielleicht doch noch irgendwas eingefallen?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nee, wollte nur noch mal 'Hallo' sagen."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Hallo!"),
                                        new Dialog(ChapterOneSprites.STORK_HEAD, "Hallo!")
                                        };
       STORK_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.STORK_HEAD, "Na doch noch was eingefallen?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nee, wollte nur Bescheidgeben, dass ich die Welt retten muss, das ist Alles."),
                                        new Dialog(ChapterOneSprites.STORK_HEAD, "Hahaha!Ja dann musst du das wohl. Viel Erfolg!")
                                        };
      CHIPMUNK_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Hallöchen junges Füchschen! Na hast du Interesse an einem meiner schönen Stoffe?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Hallo Frau Streifenhörnchen. Ich muss für meine Mutter einige Einkäufe erledigen, aber leider gehören ihre Stoffe nicht dazu.Ich dachte ich sag einfach mal 'Hallo' wenn ich schon mal in der Gegend bin..."),
                                        new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Ach das ist aber lieb von dir. Richte deiner Mutter einen schönen Gruß aus und sag ihr, dass ich ganz tolle neue Stoffe rein bekommen habe. Sie soll mal demnächst zum Plausch vorbeikommen."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok, werde ich ihr ausrichten. Schönen Tag noch Frau Streifenhörnchen."),
                                        new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Danke schön wünsche ich dir auch Füchschen.")
                                        };
      CHIPMUNK_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Hast du vielleicht doch Interesse an einem der Stoffe?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nein, nein, wollte nur schauen ob sie noch da sind."),
                                        new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Ehm... ja das bin ich."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok, gut zu wissen.")
                                        };
      CHIPMUNK_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Was ist das denn für ein wundervolles, glitzerndes Accessoire?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Sie meinen das Amulett? Das ist ein Amulett mit dem ich zwischen den Dimensionen hin und her reisen kann um die Welt zu retten."),
                                        new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Och, das ist ja niedlich. Kinder haben so viel Fantasie.")
                                        };

        FIRST_RIDDLE_BEGINNING = new List<string>() {"In einiger Entfernung ist ein Funkeln zu sehen.",
                                                    "Das Licht wird stärker und blendet nun sogar.",
                                                    "Langsam legt sich das Licht und Konturen werden sichtbar...",
                                                    "Deine Hände haben sich von alleine angehoben und du hälst nun eine Schatulle in den Händen.",
                                                    "Nach vorsichtiger Begutachtung erkennst du ein Schloss mit einem 4-Stelligen Zahlencode, jedoch lässt sich die Schatulle ohne Code icht öffnen.",
                                                    "Was willst du mit der Schatulle anstellen?"
                                                    };
        FIRST_RIDDLE_DESTROY_BOX = new List<string>() {"Du legst die Schatulle auf den Boden und trittst beherzt darauf.",
                                                    "KRACK KRACH",
                                                    "Die Schatulle ist völlig zerstört und ein heller Schimmer entweicht ihr.",
                                                    "Jemand oder etwas flüstert: Dein Handeln wird folgen haben, Auserwählter...",
                                                    "Du schaust dich um aber niemand ist hier.",
                                                    "Als du die Reste der Schatulle begutachtest fällt dir ein Amulett ins Auge. Der Stein in der Mitte ist zerbrochen.",
                                                    "Schließlich setzt du deinen Weg zur Eule fort.",
                                                    };
        FIRST_RIDDLE_AMULET_COLLECTED = new List<string>() {"Geschafft! In der Schatulle findest du ein Amulett und nimmst es an dich.",
                                                            "Gut gelaunt setzt du deinen Weg zur Eule fort.",
                                                            };
    }
}

