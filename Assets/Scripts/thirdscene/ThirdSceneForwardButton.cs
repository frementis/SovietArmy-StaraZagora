using UnityEngine;

public class ThirdSceneForwardButton : MonoBehaviour
{
    public e1move myScript; // здесь подставить название нужного скрипта
    public e2move myScript8;
    public e3move myScript1;
    public e1rotate myScript2;
    public e2rotate myScript3;
   
    public f1move myScript4;
    public f2move myScript5;
    public f3move myScript6;
    public f1rotate myScript7;
    public f2rotate myScript9;

    public c1move myScript10;

    public d3move myScript16;

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
        
        myScript16.PauseScript();


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
