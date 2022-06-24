using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev_GameProject_DogruCozum
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
