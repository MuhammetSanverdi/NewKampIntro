using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Game
{
    public interface IGameService
    {
        void Add(Games game);
        void Update(Games game);
        void Delete(Games game);
    }
}
