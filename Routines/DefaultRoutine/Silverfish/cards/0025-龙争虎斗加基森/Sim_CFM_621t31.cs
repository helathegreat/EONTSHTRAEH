using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t31 : SimTemplate //* 暗影之油 Shadow Oil
//Add 3 random Demons to your hand.
//随机将三张恶魔牌置入你的手牌。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
		    p.drawACard(CardDB.cardNameEN.malchezaarsimp, ownplay, true);
		    p.drawACard(CardDB.cardIDEnum.CFM_621_m2, ownplay, true);
		    p.drawACard(CardDB.cardIDEnum.CFM_621_m4, ownplay, true);
		}
	}
}