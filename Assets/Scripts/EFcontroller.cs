using UnityEngine;
using UnityEngine.UI;
using System.Collections;


 public class EFcontroller : MonoBehaviour {


 public Text text;
 public Font font;
 public Font font2;
 public Font font3;
 private enum States {fibili_Osio, intro_Erri , enemy_Erri, ally_Erri, nonally_Erri, introNabo_0, introNabo_1, introNabo_2, lfNabo_0, lfNabo_1, lfNabo_2, peace,
                         hum_youwar, supreme, nyum_youwar, hum_youally , nyum_youally, hum_nyum_youwar};
 private States mystate;

 	void Start ()
 	{

       mystate = States.fibili_Osio;
       

 	}




 	void Update ()
 	{
 	 print (mystate);
 	 if (mystate == States.fibili_Osio) {state_fibili_Osio();}
 	 else if (mystate == States.intro_Erri   )      {state_intro_Erri  ();}
     else if (mystate == States.enemy_Erri   )      {state_enemy_Erri  ();}
     else if (mystate == States.ally_Erri    )      {state_ally_Erri   ();}
     else if (mystate == States.nonally_Erri )      {state_nonally_Erri();}
     else if (mystate == States.introNabo_0  )      {state_introNabo_0 ();}
     else if (mystate == States.introNabo_1  )      {state_introNabo_1 ();}
     else if (mystate == States.introNabo_2  )      {state_introNabo_2 ();}
     else if (mystate == States.lfNabo_0     )      {state_lfNabo_0    ();}
     else if (mystate == States.lfNabo_1     )      {state_lfNabo_1    ();}
     else if (mystate == States.lfNabo_2     )      {state_lfNabo_2    ();}
     else if (mystate == States.peace        )      {state_peace       ();}
     else if (mystate == States.hum_youwar   )      {state_hum_youwar  ();}
     else if (mystate == States.supreme      )      {state_supreme     ();}
     else if (mystate == States.nyum_youwar  )      {state_nyum_youwar ();}
     else if (mystate == States.hum_youally  )      {state_hum_youally ();}
     else if (mystate == States.nyum_youally )      {state_nyum_youally();}
     else if (mystate == States.hum_nyum_youwar  )  {state_hum_nyum_youwar();}

        


 	}





 	void state_fibili_Osio ()

 	{               text.font = font;
           	  		text.text ="The human race has left mother earth dead and Beaten after a devastating dooms day war ." +
                    "They fled earth to an Ark(Nusuri) in geostationary orbit and formed E.R.R.I(EARTH REGENERATION AND REPOPULATION " +
                    "INITIATIVE) to plan their return to earth. Thus after 300 years of research you were created and " +
                    "sent to earth to fulfill E.R.R.I’s objectives .\n\n " +
                    "Will you support ERRI? Y or N ";
 		if (Input.GetKeyDown(KeyCode.Y)) {mystate = States.intro_Erri;}
 		else if (Input.GetKeyDown(KeyCode.N)) {mystate =States.enemy_Erri;}

 	} 

 	void state_intro_Erri ()
   	{   text.font = font;
 		text.text =" ERRI: We are ERRI.The Last hope of the Human race .\n "+
 		           "Join us and destroy the Nyumacha.Claim our home from those beasts."+
                   "You must kill there Queen. Only then will the earth be ours .\n\n" +
                   "Accept to kill the King Y or N";
 		if (Input.GetKeyDown(KeyCode.Y)) {mystate = States.ally_Erri;}
 		else if (Input.GetKeyDown(KeyCode.N)) {mystate =States.nonally_Erri;}

 	} 


 	void state_enemy_Erri ()
 	{   text.font = font; 
 		text.text ="You dare defire your Creators ??\n" +
 		           "Do not denire your purpose !\n\n" +
 		           "Kill ERRI  or Leave ERRI K or L";
 		if (Input.GetKeyDown(KeyCode.K)) {mystate = States.introNabo_0;}
 		else if (Input.GetKeyDown(KeyCode.L)) {mystate =States.lfNabo_0;}
 	}


 	void state_ally_Erri()
 	{   text.font = font;
 		text.text ="ERRI:Fullfill your purpose Takasa!\n"+
 		           "Search for the Queen!\n"+
 		           "Cleave her heart beating from its nest!\n\n" +
 		           "Accept the Mission Y or N?";
 		if (Input.GetKeyDown(KeyCode.Y)) {mystate = States.lfNabo_2;}
 		else if (Input.GetKeyDown(KeyCode.N)) {mystate =States.introNabo_2;}

 	}



 	void state_nonally_Erri ()
 	{
        text.font = font;
 		text.text ="ERRI:Our way is the only way!\n " +
 		           "You ask for peace with those Beasts\n\n?"+
 		           "Speak for Peace or Leave the ERRI P or L?";
        if (Input.GetKeyDown(KeyCode.P)) {mystate = States.introNabo_1;}
 		else if (Input.GetKeyDown(KeyCode.L)) {mystate =States.lfNabo_1;}
 	}


 	void state_introNabo_0 ()
 	{
        text.font = font2;
 		text.text ="NyumachaQueen: We are the Nyumacha life forms left behind and mutated by the earth’s conditions after dooms day. " +
 		            "We have claimed earth as our own.The human race are undeserving to return ."+
 		            "I see a day when all human will be exterminated for the evils they have done to mother earth .\n"+
 		            "Join me Takasa and we will rule all \n\n" +
                    "You can Join ,Leave or Kill the Queen J or L or K";

 		if (Input.GetKeyDown(KeyCode.L)) {mystate = States.hum_youwar;}
 		else if (Input.GetKeyDown(KeyCode.J)) {mystate =States.nyum_youally;}
        else if (Input.GetKeyDown(KeyCode.K)) {mystate =States.supreme;}
 	}


    void state_introNabo_1 ()
 	{
        text.font = font2;
 		text.text = "NyumachaQueen: We are the Nyumacha life forms left behind and mutated by the earth’s conditions after dooms day ." +
 		            "We have claimed earth as our own.The human race are undeserving to return ." +
 		            "I see a day when all human will be exterminated for the evils they have done to mother earth .\n\n"+
 		            "Peace you preach for Peace?" +
 		            "You can speak for Peace or Kill the Queen P or K";
 		if (Input.GetKeyDown(KeyCode.P)) {mystate = States.peace;}
 		else if (Input.GetKeyDown(KeyCode.K)) {mystate =States.hum_youally;}

 	}



 	 void state_introNabo_2 ()
 	{   
        text.font = font2;
 		text.text ="NyumachaQueen: We are the Nyumacha life forms left behind and mutated by the earth’s conditions after dooms day ." +
 		            "We have claimed earth as our own.The human race are undeserving to return ."+
 		            "I see a day when all human will be exterminated for the evils they have done to mother earth ."+
 		            "Join me Takasa and we will cleanse thhe cosmos of the human virus !.\n " +
                    "You can Join ,Leave or Kill the Queen J or L or K";
 		if (Input.GetKeyDown(KeyCode.K)) {mystate = States.hum_youwar;}
 		else if (Input.GetKeyDown(KeyCode.J)) {mystate =States.nyum_youally;}
 		else if (Input.GetKeyDown(KeyCode.L)) {mystate =States.hum_nyum_youwar;}

 	}

 	void state_lfNabo_0()
 	{
        text.font = font2;
 		text.text ="Nyumacha Queen: We are the Nyumacha life forms left behind and mutated by the earth’s conditions after dooms day. " +
 		            "We have claimed earth as our own.The human race are undeserving to return ."+
 		            "I see a day when all human will be exterminated for the evils they have done to mother earth .\n"+
 		            "Join me Takasa and we will rule all \n\n" +
                    "You can Join ,Leave or Kill the Queen J or L or K";

 		if (Input.GetKeyDown(KeyCode.L)) {mystate = States.hum_nyum_youwar;}
 		else if (Input.GetKeyDown(KeyCode.K)) {mystate =States.supreme;}
 		else if (Input.GetKeyDown(KeyCode.J)) {mystate =States.nyum_youally;}

 	}



 	void state_lfNabo_2()
 	{
        text.font = font2;
 		text.text ="Nyumacha Queen: We are the Nyumacha life forms left behind and mutated by the earth’s conditions after dooms day ." +
 		            "We have claimed earth as our own.The human race are undeserving to return ."+
 		            "I see a day when all human will be exterminated for the evils they have done to mother earth ."+
 		            "You Dare Kill me in my own home ?\n " +
                    "You can Join ,Leave or Kill the Queen J or L or K";
 		if (Input.GetKeyDown(KeyCode.L)) {mystate = States.hum_nyum_youwar;}
 		else if (Input.GetKeyDown(KeyCode.K)) {mystate =States.hum_youally;}
 		else if (Input.GetKeyDown(KeyCode.J)) {mystate =States.nyum_youally;}

 	}



 	void state_lfNabo_1()
 	{   
        text.font = font2;
 		text.text ="NyumachaQueen: We are the Nyumacha life forms left behind and mutated by the earth’s conditions after dooms day ." +
 		            "We have claimed earth as our own.The human race are undeserving to return ."+
 		            "I see a day when all human will be exterminated for the evils they have done to mother earth .\n"+
 		            "Join me Takasa and we will cleanse thhe cosmos of the human virus !.\n " +
                    "You can Join ,Leave or Kill the Queen J or L or K";

 		if (Input.GetKeyDown(KeyCode.L)) {mystate = States.hum_nyum_youwar;}
 		else if (Input.GetKeyDown(KeyCode.K)) {mystate =States.hum_youwar;}
 		else if (Input.GetKeyDown(KeyCode.J)) {mystate =States.nyum_youally;}

 	}



 	void state_peace()
 	{
        text.font = font3;
 		text.text ="You Lead the Humans and the Nyumacha to Peace .\n" +
 		           "They share New Earth as brothers .\n " +
 		           "Will thhis peace last ?";


 	}

    void state_hum_youwar()
    {
        text.font = font3;
    	text.text ="After the death of the Nyumacha Queen you rode to war with the humans .\n"+
    	           "It lasted for decades but your victory will soon be reached ." ;

    }



    void state_supreme()
    {
        text.font = font3;
    	text.text ="There is no one Left to challenge you .\n"+
    	           "Your are King/Queen of new earth ." ;

    }



    void state_nyum_youwar ()
    {
        text.font = font3;
    	text.text ="After the death of ERRI you rode to war with the Nyumacha .\n"+
    	           "It lasted for decades but your victory will soon be reached .";

    }



    void state_hum_youally ()
    {
        text.font = font3;
    	text.text = "You ally with ERRI and together you crash the Nyumacha from existence .\n" +
    	            "They are no more now you and the humans rain supreme" ;

    }



    void state_nyum_youally()
    {
        text.font = font3;
    	text.text ="You ally with Nyumacha and together you exterminate the human .\n" +
    	            "They are no more now you and the Nyumacha rain supreme" ;

    }



    void state_hum_nyum_youwar()
    {
        text.font = font3;
    	text.text ="You the Nyumacha and the Humans go to war. \n"+
    	           "The colliding of these three factions recreated dooms day .\n"+
    	           "You victory over earth will come soon ....but what will be left of it ?";
    	            

    }
   public void Restart()
   {
    
    mystate = States.fibili_Osio;

   }
      
    
}