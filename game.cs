using System;
using BoardSpace;
using PlayerSpace;

namespace GameSpace {
	class Game {
		Player player1 = new Player();
		Player player2 = new Player();
		Board gameBoard = new Board();
	
	public Game() {
		player1.setPlayerType('x');
		player2.setPlayerType('o');
		player1.active = true;
		switchTurn();
	}
	
	public bool gaugeWin(Board theBoard) {
		if ((theBoard.topleft == 'o' || theBoard.topleft == 'x') && ((theBoard.topleft == theBoard.topcenter) && (theBoard.topleft == theBoard.topright) && (theBoard.topcenter == theBoard.topright))) {
			return true;
		}
	
		else if ((theBoard.centerleft == 'o' || theBoard.centerleft == 'x') && ((theBoard.centerleft == theBoard.centercenter) && (theBoard.centerleft == theBoard.centerright) && (theBoard.centercenter == theBoard.centerright))) {
			return true;
		}
	
		else if ((theBoard.bottomleft == 'o' || theBoard.bottomleft == 'x') && ((theBoard.bottomleft == theBoard.bottomcenter) && (theBoard.bottomcenter == theBoard.bottomright) && (theBoard.bottomleft == theBoard.bottomright))) {
			return true;
		}
		
		else if ((theBoard.topleft == 'o' || theBoard.topleft == 'x') && ((theBoard.topleft == theBoard.centerleft) && (theBoard.topleft == theBoard.bottomleft) && (theBoard.centerleft == theBoard.bottomleft))) {
			return true;
		}
		
		else if ((theBoard.topcenter == 'o' || theBoard.topcenter == 'x') && ((theBoard.topcenter == theBoard.centercenter) && (theBoard.centercenter == theBoard.bottomcenter) && (theBoard.topcenter == theBoard.bottomcenter))) {
			return true;
		}
		
		else if ((theBoard.topright == 'o' || theBoard.topright == 'x') && ((theBoard.topright == theBoard.centerright) && (theBoard.centerright == theBoard.bottomright) && (theBoard.topright == theBoard.bottomright))) {
			return true;
		}
		
		else if ((theBoard.centercenter == 'o' || theBoard.centercenter == 'x') && (((theBoard.centercenter == theBoard.topleft) && (theBoard.topleft == theBoard.bottomright) && (theBoard.centercenter == theBoard.bottomright)) || ((theBoard.centercenter == theBoard.bottomleft) && (theBoard.centercenter == theBoard.topright) && (theBoard.bottomleft == theBoard.topright)))) {
			return true;
		}
		
		else {
			return false;
		}
	}
	
	private void taketurn(Player thePlayer) {
	if (gaugeWin(gameBoard)) {
		gameBoard.printBoard();
		Console.WriteLine("\nGame Over");
	}
	else {
		string answer;
		bool taken = false;
		gameBoard.printBoard();
		Console.Write("Where would you like to move? (tl, tc, tr, cl, cc, cr, bl, bc, br): ");
		answer = Console.ReadLine();
		if (answer == "tl" || answer == "TL") {
			thePlayer.topleft(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "tc" || answer == "TC") {
			thePlayer.topcenter(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "tr" || answer == "TR") {
			thePlayer.topright(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "cl" || answer == "CL") {
			thePlayer.centerleft(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "cc" || answer == "CC") {
			thePlayer.centercenter(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "cr" || answer == "CR") {
			thePlayer.centerright(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "bl" || answer == "BL") {
			thePlayer.bottomleft(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "bc" || answer == "BC") {
			thePlayer.bottomcenter(ref gameBoard, ref taken);
			Console.WriteLine(taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else if (answer == "br" || answer == "BR") {
			thePlayer.bottomright(ref gameBoard, ref taken);
			if (taken) {
			taketurn(thePlayer);
			}
		}
		else {
			taketurn(thePlayer);
		}
		switchTurn();
	}
	}
	
	private void switchTurn() {
	if (player1.active) {
		player1.active = false;
		player2.active = true;
		taketurn(player2);
	}
	else {
		player2.active = false;
		player1.active = true;
		taketurn(player1);
	}
	
	}
	
}
}