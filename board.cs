using System;

namespace BoardSpace {
	class Board {
	public char topleft; 
	public char topcenter;
	public char topright;
	public char centerleft;
	public char centercenter;
	public char centerright;
	public char bottomleft;
	public char bottomcenter;
	public char bottomright;
	
	public string toptopleft() {
		string result;
		result = "\t    #";
		return result;
	}
	public string toptopcenter() {
		string result;
		result = "   #";
		return result;
	}
	public string toptopright() {
		string result;
		result = "    ";
		return result;
	}
	public string topbottomleft() {
		string result;
		if (topleft == 'x') {
			result = "\t  X #";
			return result;
		}
		else if (topleft == 'o') {
			result = "\t  O #";
			return result;
		}
		else {
			result = "\t    #";
			return result;
		}
	}
	public string topbottomcenter() {
		string result;
		if (topcenter == 'x') {
			result = " X #";
			return result;
		}
		else if (topcenter == 'o') {
			result = " O #";
			return result;
		}
		else {
			result = "   #";
			return result;
		}
	}
	public string topbottomright() {
		string result;
		if (topright == 'x') {
			result = " X  ";
			return result;
		}
		else if (topright == 'o') {
			result = " O  ";
			return result;
		}
		else {
			result = "    ";
			return result;
		}
	}
	public string topline() {
		string result;
		result = "\t#############";
		return result;
	}
	public string topcenterleft() {
		string result;
		result = "\t    #";
		return result;
	}
	public string topcentercenter() {
		string result;
		result = "   #";
		return result;
	}
	public string topcenterright() {
		string result;
		result = "    ";
		return result;
	}
	public string bottomcenterleft() {
		string result;
		if (centerleft == 'x') {
			result = "\t  X #";
			return result;
		}
		else if (centerleft == 'o') {
			result = "\t  O #";
			return result;
		}
		else {
		result = "\t    #";
		return result;
		}
	}
	public string bottomcentercenter() {
		string result;
		if (centercenter == 'x') {
			result = " X #";
			return result;
		}
		else if (centercenter == 'o') {
			result = " O #";
			return result;
		}
		else {
			result = "   #";
			return result;
		}
	}
	public string bottomcenterright() {
		string result;
		if (centerright == 'x') {
			result = " X  ";
			return result;
		}
		else if (centerright == 'o') {
			result = " O  ";
			return result;
		}
		else {
			result = "    ";
			return result;
		}
	}
	public string bottomline() {
		string result;
		result = "\t#############";
		return result;
	}
	public string bottomtopleft() {
		string result;
		if (bottomleft == 'x') {
			result = "\t  X #";
			return result;
		}
		else if (bottomleft == 'o') {
			result = "\t  O #";
			return result;
		}
		else {
		result = "\t    #";
		return result;
		}
	}
	public string bottomtopcenter() {
		string result;
		if (bottomcenter == 'x') {
			result = " X #";
			return result;
		}
		else if (bottomcenter == 'o') {
			result = " O #";
			return result;
		}
		else {
		result = "   #";
		return result;
		}
	}
	public string bottomtopright() {
		string result;
		if (bottomright == 'x') {
			result = " X  ";
			return result;
		}
		else if (bottomright == 'o') {
			result = " O  ";
			return result;
		}
		else {
		result = "    ";
		return result;
		}
	}
	public string bottombottomleft() {
		string result;
		result = "\t    #";
		return result;
	}
	public string bottombottomcenter() {
		string result;
		result = "   #";
		return result;
	}
	public string bottombottomright() {
		string result;
		result = "    ";
		return result;
	}
	public void printBoard() {
		Console.Write(toptopleft());
		Console.Write(toptopcenter());
		Console.WriteLine(toptopright());
		Console.Write(topbottomleft());
		Console.Write(topbottomcenter());
		Console.WriteLine(topbottomright());
		Console.WriteLine(topline());
		Console.Write(topcenterleft());
		Console.Write(topcentercenter());
		Console.WriteLine(topcenterright());
		Console.Write(bottomcenterleft());
		Console.Write(bottomcentercenter());
		Console.WriteLine(bottomcenterright());
		Console.WriteLine(bottomline());
		Console.Write(bottomtopleft());
		Console.Write(bottomtopcenter());
		Console.WriteLine(bottomtopright());
		Console.Write(bottombottomleft());
		Console.Write(bottombottomcenter());
		Console.WriteLine(bottombottomright());
	}
	}
}