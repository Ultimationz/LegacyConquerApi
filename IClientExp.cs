using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConquer.Api
{
    public interface IClientExp
    {
        double Percent { get; }
        void AwardPercent(int percent);
        void AwardExpBall(int amountOfBalls = 1);
    }
}
