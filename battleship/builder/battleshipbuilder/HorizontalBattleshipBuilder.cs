using System;
using System.Collections.Generic;

namespace flarebattleship
{
    class HorizontalBattleshipBuilder: BattleshipBuilder
    {
        public override XYBattleship Build(XYPosition position, int size)
        {
            var occupiedPositions = new List<XYOccupiedPosition>();
            for (var i=0; i < size; i++)
            {
                var occupiedPosition = new XYOccupiedPosition(new XYPosition(position.X+i, position.Y));
                occupiedPositions.Add(occupiedPosition);
            }

            return new XYBattleship(occupiedPositions);
        }
    }
}