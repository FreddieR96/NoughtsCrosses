using System;
using BoardSpace;

namespace PlayerSpace {
	class Player {
		private char playerType;
		public bool active;
		public void setPlayerType(char player) {
			playerType = player;
		}
		public void topleft(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.topleft)){
				taken = true;
			} else {
				theboard.topleft = playerType;
				taken = false;
			}
		}
		public void topcenter(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.topcenter)){
				taken = true;
			} else {
				theboard.topcenter = playerType;
				taken = false;
			}
		}
		public void topright(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.topright)){
				taken = true;
			} else {
				theboard.topright = playerType;
				taken = false;
			}
		}
		public void centerleft(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.centerleft)){
				taken = true;
			} else {
				theboard.centerleft = playerType;
				taken = false;
			}
		}
		public void centercenter(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.centercenter)){
				taken = true;
			} else {
				theboard.centercenter = playerType;
				taken = false;
			}
		}
		public void centerright(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.centerright)){
				taken = true;
			} else {
				theboard.centerright = playerType;
				taken = false;
			}
		}
		public void bottomleft(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.bottomleft)){
				taken = true;
			} else {
				theboard.bottomleft = playerType;
				taken = false;
			}
		}
		public void bottomcenter(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.bottomcenter)){
				taken = true;
			} else {
				theboard.bottomcenter = playerType;
				taken = false;
			}
		}
		public void bottomright(ref Board theboard, ref bool taken) {
			if (evaluate(theboard.bottomright)){
				taken = true;
			} else {
				theboard.bottomright = playerType;
				taken = false;
			}
		}
		public bool evaluate(char square) {
		return square == 'x' || square == 'o' ? true : false;
			
		}
	}
}