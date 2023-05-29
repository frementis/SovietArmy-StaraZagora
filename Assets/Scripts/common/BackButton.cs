using UnityEngine;

public class BackButton : MonoBehaviour
{
    public a1move myScript;
    public a2move myScript8; // здесь подставить название нужного скрипта
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
        myScript.PauseScript();
        myScript1.PauseScript();
        myScript2.PauseScript();
        myScript3.PauseScript();
        myScript8.PauseScript();

        myScript4.ResumeScript();
        myScript5.ResumeScript();
        myScript6.ResumeScript();
        myScript7.ResumeScript();
        myScript9.ResumeScript();

        myScript10.PauseScript();
        myScript11.PauseScript();
        myScript12.PauseScript();
        myScript13.PauseScript();

        myScript14.ResumeScript();
        myScript15.ResumeScript();
        myScript16.ResumeScript();
        myScript17.ResumeScript();

        myScript18.PauseScript();
        myScript19.PauseScript();
        myScript20.PauseScript();
        myScript21.PauseScript();
        myScript22.PauseScript();
        myScript23.PauseScript();
        myScript24.PauseScript();
        myScript25.PauseScript();

        myScript26.ResumeScript();
        myScript27.ResumeScript();
        myScript28.ResumeScript();
        myScript29.ResumeScript();
        myScript30.ResumeScript();
        myScript31.ResumeScript();
        myScript32.ResumeScript();
        myScript33.ResumeScript();

        myScript34.PauseScript();
        myScript35.ResumeScript();

    }

}
