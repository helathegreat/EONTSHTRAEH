using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Passions
	//迷情护符
	//Take control of an enemy minion until the end of your turn.<i>(It has 1 Attack this turn!)</i>
	//直到你的回合结束，夺取一个敌方随从的控制权。<i>（在本回合中其攻击力为1！）</i>
	class Sim_VAC_959t01 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null && !target.own)
            {
                // 夺取敌方随从的控制权，直到回合结束
                p.minionGetControlled(target, ownplay, true);

                // 将该随从的攻击力设为1，仅限本回合
                p.minionSetAngrToX(target, 1);
            }
        }

    }
}
