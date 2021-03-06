
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;

/*
using static BattleShips.GameController;
using static BattleShips.UtilityFunctions;
using static BattleShips.GameResources;
using static BattleShips.DeploymentController;
using static BattleShips.DiscoveryController;
using static BattleShips.EndingGameController;
using static BattleShips.HighScoreController;
using static BattleShips.MenuController;
using stativ BattleShips.GameState;
*/

namespace BattleShips
{
	static class GameLogic
	{
		public static void Main()
		{
			//Opens a new Graphics Window
			SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

			//Load Resources
			GameResources.LoadResources();

			SwinGame.PlayMusic(GameResources.GameMusic("Background"));

			new GameController();

			//Game Loop
			do {
				GameController.HandleUserInput();
				GameController.DrawScreen();
			} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

			SwinGame.StopMusic();

			//Free Resources and Close Audio, to end the program.
			GameResources.FreeResources();
		}
	}

	//=======================================================
	//Service provided by Telerik (www.telerik.com)
	//Conversion powered by NRefactory.
	//Twitter: @telerik
	//Facebook: facebook.com/telerik
	//=======================================================
}