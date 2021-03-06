using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingCode : MonoBehaviour
{
    public RhythmGameMapper rhythms;

    public void TutorialRedCardinalPatternDemo()
    {
                    rhythms.loopType = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 5;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Bot Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void RedCardinalTutorialGameplay()
    {
                    rhythms.loopType = 2;
                    //Event Clear
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    //Cardinal Jump Out
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 5;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    //Cardinal Call
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Player Response
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void TutorialBlueJayPatterns()
    {
                    rhythms.loopType = 3;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 6;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Bot Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 8;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void BlueJayTutorialGameplay()
    {
                    rhythms.loopType = 4;
                    //Event Clear
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    //Blue Jay Hop Out
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 6;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    //Blue Jay Call
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Player Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 7;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }
    public void TutorialBullFinchPatterns()
    {
                    rhythms.loopType = 5;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 9;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 10;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Bot Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 12;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

     public void BullFinchTutorialGamePlay()
    {
                    rhythms.loopType = 6;
                    //Event Clear
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    //BullFinch Hop out
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 9;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    //BullFinch Call
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 4;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 10;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Player Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 11;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void TutorialParrotPatterns()
    {
                    rhythms.loopType = 7;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 13;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 2;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 16;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Bot Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 14;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void ParrotTutorialGamePlay()
    {
                    rhythms.loopType = 8;
                    //Event Clear
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    //Parrot Hop Out
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 13;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    //Parrot Call
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 16;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    //Player Call
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 15;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }

    public void Brazil()
    {
         rhythms.loopType = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;
    }  

    public void backingTrack1()
    {
         rhythms.loopType = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;

                    rhythms.Events[4].beatsBtwWave = 1;
                    rhythms.Events[4].eventType = 13;
                    rhythms.Events[4].noOfEvents = 1;
                    rhythms.Events[4].beatMode = true;
                    rhythms.Events[4].timeMode = false;
                    rhythms.Events[4].beatRest = true;
                    rhythms.Events[4].timeRest = false;
                    
                    rhythms.Events[5].beatsBtwWave = 1;
                    rhythms.Events[5].eventType = 16;
                    rhythms.Events[5].noOfEvents = 1;
                    rhythms.Events[5].beatMode = true;
                    rhythms.Events[5].timeMode = false;
                    rhythms.Events[5].beatRest = true;
                    rhythms.Events[5].timeRest = false;

                    rhythms.Events[6].beatsBtwWave = 3;
                    rhythms.Events[6].eventType = 15;
                    rhythms.Events[6].noOfEvents = 1;
                    rhythms.Events[6].beatMode = true;
                    rhythms.Events[6].timeMode = false;
                    rhythms.Events[6].beatRest = true;
                    rhythms.Events[6].timeRest = false;

                    rhythms.Events[7].beatsBtwWave = 1;
                    rhythms.Events[7].eventType = 0;
                    rhythms.Events[7].noOfEvents = 1;
                    rhythms.Events[7].beatMode = true;
                    rhythms.Events[7].timeMode = false;
                    rhythms.Events[7].beatRest = true;
                    rhythms.Events[7].timeRest = false;

                    rhythms.Events[8].beatsBtwWave = 1;
                    rhythms.Events[8].eventType = 5;
                    rhythms.Events[8].noOfEvents = 1;
                    rhythms.Events[8].beatMode = true;
                    rhythms.Events[8].timeMode = false;
                    rhythms.Events[8].beatRest = true;
                    rhythms.Events[8].timeRest = false;

                    rhythms.Events[9].beatsBtwWave = 1;
                    rhythms.Events[9].eventType = 2;
                    rhythms.Events[9].noOfEvents = 1;
                    rhythms.Events[9].beatMode = true;
                    rhythms.Events[9].timeMode = false;
                    rhythms.Events[9].beatRest = true;
                    rhythms.Events[9].timeRest = false;

                    rhythms.Events[10].beatsBtwWave = 1;
                    rhythms.Events[10].eventType = 1;
                    rhythms.Events[10].noOfEvents = 1;
                    rhythms.Events[10].beatMode = true;
                    rhythms.Events[10].timeMode = false;
                    rhythms.Events[10].beatRest = true;
                    rhythms.Events[10].timeRest = false;

                    rhythms.Events[11].beatsBtwWave = 3;
                    rhythms.Events[11].eventType = 6;
                    rhythms.Events[11].noOfEvents = 1;
                    rhythms.Events[11].beatMode = true;
                    rhythms.Events[11].timeMode = false;
                    rhythms.Events[11].beatRest = true;
                    rhythms.Events[11].timeRest = false;

                    rhythms.Events[12].beatsBtwWave = 3;
                    rhythms.Events[12].eventType = 4;
                    rhythms.Events[12].noOfEvents = 1;
                    rhythms.Events[12].beatMode = true;
                    rhythms.Events[12].timeMode = false;
                    rhythms.Events[12].beatRest = true;
                    rhythms.Events[12].timeRest = false;

                    rhythms.Events[13].beatsBtwWave = 1;
                    rhythms.Events[13].eventType = 7;
                    rhythms.Events[13].noOfEvents = 1;
                    rhythms.Events[13].beatMode = true;
                    rhythms.Events[13].timeMode = false;
                    rhythms.Events[13].beatRest = true;
                    rhythms.Events[13].timeRest = false;

                    rhythms.Events[14].beatsBtwWave = 1;
                    rhythms.Events[14].eventType = 7;
                    rhythms.Events[14].noOfEvents = 1;
                    rhythms.Events[14].beatMode = true;
                    rhythms.Events[14].timeMode = false;
                    rhythms.Events[14].beatRest = true;
                    rhythms.Events[14].timeRest = false;

                    rhythms.Events[15].beatsBtwWave = 1;
                    rhythms.Events[15].eventType = 5;
                    rhythms.Events[15].noOfEvents = 1;
                    rhythms.Events[15].beatMode = true;
                    rhythms.Events[15].timeMode = false;
                    rhythms.Events[15].beatRest = true;
                    rhythms.Events[15].timeRest = false;

                    rhythms.Events[16].beatsBtwWave = 1;
                    rhythms.Events[16].eventType = 2;
                    rhythms.Events[16].noOfEvents = 1;
                    rhythms.Events[16].beatMode = true;
                    rhythms.Events[16].timeMode = false;
                    rhythms.Events[16].beatRest = true;
                    rhythms.Events[16].timeRest = false;

                    rhythms.Events[17].beatsBtwWave = 2;
                    rhythms.Events[17].eventType = 1;
                    rhythms.Events[17].noOfEvents = 1;
                    rhythms.Events[17].beatMode = true;
                    rhythms.Events[17].timeMode = false;
                    rhythms.Events[17].beatRest = true;
                    rhythms.Events[17].timeRest = false;
                    
    }

    public void backingTrack2()
    {
         rhythms.loopType = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 1].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 1].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 1].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatsBtwWave = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 2].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 2].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 2].timeRest = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatsBtwWave = 3;
                    rhythms.Events[rhythms.currentEventNumber+ 3].eventType = 0;
                    rhythms.Events[rhythms.currentEventNumber+ 3].noOfEvents = 1;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatMode = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeMode = false;
                    rhythms.Events[rhythms.currentEventNumber+ 3].beatRest = true;
                    rhythms.Events[rhythms.currentEventNumber+ 3].timeRest = false;

                    rhythms.Events[4].beatsBtwWave = 1;
                    rhythms.Events[4].eventType = 6;
                    rhythms.Events[4].noOfEvents = 1;
                    rhythms.Events[4].beatMode = true;
                    rhythms.Events[4].timeMode = false;
                    rhythms.Events[4].beatRest = true;
                    rhythms.Events[4].timeRest = false;
                    
                    rhythms.Events[5].beatsBtwWave = 3;
                    rhythms.Events[5].eventType = 4;
                    rhythms.Events[5].noOfEvents = 1;
                    rhythms.Events[5].beatMode = true;
                    rhythms.Events[5].timeMode = false;
                    rhythms.Events[5].beatRest = true;
                    rhythms.Events[5].timeRest = false;

                    rhythms.Events[6].beatsBtwWave = 1;
                    rhythms.Events[6].eventType = 7;
                    rhythms.Events[6].noOfEvents = 1;
                    rhythms.Events[6].beatMode = true;
                    rhythms.Events[6].timeMode = false;
                    rhythms.Events[6].beatRest = true;
                    rhythms.Events[6].timeRest = false;

                    rhythms.Events[7].beatsBtwWave = 0;
                    rhythms.Events[7].eventType = 0;
                    rhythms.Events[7].noOfEvents = 1;
                    rhythms.Events[7].beatMode = true;
                    rhythms.Events[7].timeMode = false;
                    rhythms.Events[7].beatRest = true;
                    rhythms.Events[7].timeRest = false;

                    rhythms.Events[8].beatsBtwWave = 1;
                    rhythms.Events[8].eventType = 13;
                    rhythms.Events[8].noOfEvents = 1;
                    rhythms.Events[8].beatMode = true;
                    rhythms.Events[8].timeMode = false;
                    rhythms.Events[8].beatRest = true;
                    rhythms.Events[8].timeRest = false;

                    rhythms.Events[9].beatsBtwWave = 1;
                    rhythms.Events[9].eventType = 16;
                    rhythms.Events[9].noOfEvents = 1;
                    rhythms.Events[9].beatMode = true;
                    rhythms.Events[9].timeMode = false;
                    rhythms.Events[9].beatRest = true;
                    rhythms.Events[9].timeRest = false;

                    rhythms.Events[10].beatsBtwWave = 4;
                    rhythms.Events[10].eventType = 15;
                    rhythms.Events[10].noOfEvents = 1;
                    rhythms.Events[10].beatMode = true;
                    rhythms.Events[10].timeMode = false;
                    rhythms.Events[10].beatRest = true;
                    rhythms.Events[10].timeRest = false;

                    rhythms.Events[11].beatsBtwWave = 1;
                    rhythms.Events[11].eventType = 13;
                    rhythms.Events[11].noOfEvents = 1;
                    rhythms.Events[11].beatMode = true;
                    rhythms.Events[11].timeMode = false;
                    rhythms.Events[11].beatRest = true;
                    rhythms.Events[11].timeRest = false;

                    rhythms.Events[12].beatsBtwWave = 1;
                    rhythms.Events[12].eventType = 16;
                    rhythms.Events[12].noOfEvents = 1;
                    rhythms.Events[12].beatMode = true;
                    rhythms.Events[12].timeMode = false;
                    rhythms.Events[12].beatRest = true;
                    rhythms.Events[12].timeRest = false;

                    rhythms.Events[13].beatsBtwWave = 1;
                    rhythms.Events[13].eventType = 15;
                    rhythms.Events[13].noOfEvents = 1;
                    rhythms.Events[13].beatMode = true;
                    rhythms.Events[13].timeMode = false;
                    rhythms.Events[13].beatRest = true;
                    rhythms.Events[13].timeRest = false;

                    rhythms.Events[14].beatsBtwWave = 10;
                    rhythms.Events[14].eventType = 0;
                    rhythms.Events[14].noOfEvents = 1;
                    rhythms.Events[14].beatMode = true;
                    rhythms.Events[14].timeMode = false;
                    rhythms.Events[14].beatRest = true;
                    rhythms.Events[14].timeRest = false;

                    rhythms.Events[15].beatsBtwWave = 1;
                    rhythms.Events[15].eventType = 6;
                    rhythms.Events[15].noOfEvents = 1;
                    rhythms.Events[15].beatMode = true;
                    rhythms.Events[15].timeMode = false;
                    rhythms.Events[15].beatRest = true;
                    rhythms.Events[15].timeRest = false;

                    rhythms.Events[16].beatsBtwWave = 3;
                    rhythms.Events[16].eventType = 4;
                    rhythms.Events[16].noOfEvents = 1;
                    rhythms.Events[16].beatMode = true;
                    rhythms.Events[16].timeMode = false;
                    rhythms.Events[16].beatRest = true;
                    rhythms.Events[16].timeRest = false;

                    rhythms.Events[17].beatsBtwWave = 2;
                    rhythms.Events[17].eventType = 7;
                    rhythms.Events[17].noOfEvents = 1;
                    rhythms.Events[17].beatMode = true;
                    rhythms.Events[17].timeMode = false;
                    rhythms.Events[17].beatRest = true;
                    rhythms.Events[17].timeRest = false;

                    rhythms.Events[18].beatsBtwWave = 1;
                    rhythms.Events[18].eventType = 0;
                    rhythms.Events[18].noOfEvents = 1;
                    rhythms.Events[18].beatMode = true;
                    rhythms.Events[18].timeMode = false;
                    rhythms.Events[18].beatRest = true;
                    rhythms.Events[18].timeRest = false;

                    rhythms.Events[19].beatsBtwWave = 1;
                    rhythms.Events[19].eventType = 13;
                    rhythms.Events[19].noOfEvents = 1;
                    rhythms.Events[19].beatMode = true;
                    rhythms.Events[19].timeMode = false;
                    rhythms.Events[19].beatRest = true;
                    rhythms.Events[19].timeRest = false;

                    rhythms.Events[20].beatsBtwWave = 1;
                    rhythms.Events[20].eventType = 16;
                    rhythms.Events[20].noOfEvents = 1;
                    rhythms.Events[20].beatMode = true;
                    rhythms.Events[20].timeMode = false;
                    rhythms.Events[20].beatRest = true;
                    rhythms.Events[20].timeRest = false;

                     rhythms.Events[21].beatsBtwWave = 1;
                    rhythms.Events[21].eventType = 15;
                    rhythms.Events[21].noOfEvents = 1;
                    rhythms.Events[21].beatMode = true;
                    rhythms.Events[21].timeMode = false;
                    rhythms.Events[21].beatRest = true;
                    rhythms.Events[21].timeRest = false;
                    

                    rhythms.Events[22].beatsBtwWave = 3;
                    rhythms.Events[22].eventType = 0;
                    rhythms.Events[22].noOfEvents = 1;
                    rhythms.Events[22].beatMode = true;
                    rhythms.Events[22].timeMode = false;
                    rhythms.Events[22].beatRest = true;
                    rhythms.Events[22].timeRest = false;

                    rhythms.Events[23].beatsBtwWave = 1;
                    rhythms.Events[23].eventType = 0;
                    rhythms.Events[23].noOfEvents = 1;
                    rhythms.Events[23].beatMode = true;
                    rhythms.Events[23].timeMode = false;
                    rhythms.Events[23].beatRest = true;
                    rhythms.Events[23].timeRest = false;

                    rhythms.Events[24].beatsBtwWave = 1;
                    rhythms.Events[24].eventType = 5;
                    rhythms.Events[24].noOfEvents = 1;
                    rhythms.Events[24].beatMode = true;
                    rhythms.Events[24].timeMode = false;
                    rhythms.Events[24].beatRest = true;
                    rhythms.Events[24].timeRest = false;

                    rhythms.Events[25].beatsBtwWave = 2;
                    rhythms.Events[25].eventType = 2;
                    rhythms.Events[25].noOfEvents = 1;
                    rhythms.Events[25].beatMode = true;
                    rhythms.Events[25].timeMode = false;
                    rhythms.Events[25].beatRest = true;
                    rhythms.Events[25].timeRest = false;

                    rhythms.Events[26].beatsBtwWave = 1;
                    rhythms.Events[26].eventType = 1;
                    rhythms.Events[26].noOfEvents = 1;
                    rhythms.Events[26].beatMode = true;
                    rhythms.Events[26].timeMode = false;
                    rhythms.Events[26].beatRest = true;
                    rhythms.Events[26].timeRest = false;

                    rhythms.Events[27].beatsBtwWave = 3;
                    rhythms.Events[27].eventType = 0;
                    rhythms.Events[27].noOfEvents = 1;
                    rhythms.Events[27].beatMode = true;
                    rhythms.Events[27].timeMode = false;
                    rhythms.Events[27].beatRest = true;
                    rhythms.Events[27].timeRest = false;

                    rhythms.Events[28].beatsBtwWave = 1;
                    rhythms.Events[28].eventType = 5;
                    rhythms.Events[28].noOfEvents = 1;
                    rhythms.Events[28].beatMode = true;
                    rhythms.Events[28].timeMode = false;
                    rhythms.Events[28].beatRest = true;
                    rhythms.Events[28].timeRest = false;

                    rhythms.Events[29].beatsBtwWave = 2;
                    rhythms.Events[29].eventType = 2;
                    rhythms.Events[29].noOfEvents = 1;
                    rhythms.Events[29].beatMode = true;
                    rhythms.Events[29].timeMode = false;
                    rhythms.Events[29].beatRest = true;
                    rhythms.Events[29].timeRest = false;

                    rhythms.Events[30].beatsBtwWave = 1;
                    rhythms.Events[30].eventType = 1;
                    rhythms.Events[30].noOfEvents = 1;
                    rhythms.Events[30].beatMode = true;
                    rhythms.Events[30].timeMode = false;
                    rhythms.Events[30].beatRest = true;
                    rhythms.Events[30].timeRest = false;

                    rhythms.Events[31].beatsBtwWave = 1;
                    rhythms.Events[31].eventType = 0;
                    rhythms.Events[31].noOfEvents = 1;
                    rhythms.Events[31].beatMode = true;
                    rhythms.Events[31].timeMode = false;
                    rhythms.Events[31].beatRest = true;
                    rhythms.Events[31].timeRest = false;

                     rhythms.Events[32].beatsBtwWave = 1;
                    rhythms.Events[32].eventType = 5;
                    rhythms.Events[32].noOfEvents = 1;
                    rhythms.Events[32].beatMode = true;
                    rhythms.Events[32].timeMode = false;
                    rhythms.Events[32].beatRest = true;
                    rhythms.Events[32].timeRest = false;

                     rhythms.Events[33].beatsBtwWave = 1;
                    rhythms.Events[33].eventType = 0;
                    rhythms.Events[33].noOfEvents = 1;
                    rhythms.Events[33].beatMode = true;
                    rhythms.Events[33].timeMode = false;
                    rhythms.Events[33].beatRest = true;
                    rhythms.Events[33].timeRest = false;

                    rhythms.Events[34].beatsBtwWave = 2;
                    rhythms.Events[34].eventType = 2;
                    rhythms.Events[34].noOfEvents = 1;
                    rhythms.Events[34].beatMode = true;
                    rhythms.Events[34].timeMode = false;
                    rhythms.Events[34].beatRest = true;
                    rhythms.Events[34].timeRest = false;

                     rhythms.Events[35].beatsBtwWave = 1;
                    rhythms.Events[35].eventType = 1;
                    rhythms.Events[35].noOfEvents = 1;
                    rhythms.Events[35].beatMode = true;
                    rhythms.Events[35].timeMode = false;
                    rhythms.Events[35].beatRest = true;
                    rhythms.Events[35].timeRest = false;

                     rhythms.Events[36].beatsBtwWave = 3;
                    rhythms.Events[36].eventType = 0;
                    rhythms.Events[36].noOfEvents = 1;
                    rhythms.Events[36].beatMode = true;
                    rhythms.Events[36].timeMode = false;
                    rhythms.Events[36].beatRest = true;
                    rhythms.Events[36].timeRest = false;
                    
    }   
}
