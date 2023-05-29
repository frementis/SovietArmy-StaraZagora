using UnityEngine;

public class ForwardButton : MonoBehaviour
{
    public a1move myScript;
    public a2move myScript8;// здесь подставить название нужного скрипта
    public a3move myScript1;
    public a4move myScript2;
    public a1rotate myScript3;

    public b1move myScript4;
    public b2move myScript5;
    public b3move myScript6;
    public b4move myScript9;
    public b1rotate myScript7;

    public c1move myScript10;
    public c2move myScript11;
    public c3move myScript12;
    public c1rotate myScript13;

    public d1move myScript14;
    public d2move myScript15;
    public d3move myScript16;
    public d1rotate myScript17;

    public RotateOnMoveForward myScript18;
    public RotateOnMoveForward myScript19;
    public RotateOnMoveForward myScript20;
    public RotateOnMoveForward myScript21;
    public RotateOnMoveForward myScript22;
    public RotateOnMoveForward myScript23;
    public RotateOnMoveForward myScript24;
    public RotateOnMoveForward myScript25;


    public RotateOnMoveBack myScript26;
    public RotateOnMoveBack myScript27;
    public RotateOnMoveBack myScript28;
    public RotateOnMoveBack myScript29;
    public RotateOnMoveBack myScript30;
    public RotateOnMoveBack myScript31;
    public RotateOnMoveBack myScript32;
    public RotateOnMoveBack myScript33;

    public TimeSlider myScript34;
    public TimeSliderBack myScript35;

    public void OnPauseButtonClick()
    {
        myScript.ResumeScript();
        myScript8.ResumeScript();
        myScript1.ResumeScript();
        myScript2.ResumeScript();
        myScript3.ResumeScript();

        myScript4.PauseScript();
        myScript5.PauseScript();
        myScript6.PauseScript();
        myScript7.PauseScript();
        myScript9.PauseScript();

        myScript10.ResumeScript();
        myScript11.ResumeScript();
        myScript12.ResumeScript();
        myScript13.ResumeScript();

        myScript14.PauseScript();
        myScript15.PauseScript();
        myScript16.PauseScript();
        myScript17.PauseScript();


        myScript18.ResumeScript();
        myScript19.ResumeScript();
        myScript20.ResumeScript();
        myScript21.ResumeScript();
        myScript22.ResumeScript();
        myScript23.ResumeScript();
        myScript24.ResumeScript();
        myScript25.ResumeScript();

        myScript26.PauseScript();
        myScript27.PauseScript();
        myScript28.PauseScript();
        myScript29.PauseScript();
        myScript30.PauseScript();
        myScript31.PauseScript();
        myScript31.PauseScript();
        myScript33.PauseScript();

        myScript34.ResumeScript();
        myScript35.PauseScript();
    }
}
