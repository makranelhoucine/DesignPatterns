﻿using System;

namespace DP.Behavioral.ChainOfResp
{
    internal class ResponsableDepartement : Approver
    {
        public override void EtudieDemandeAugmentation(DemandeAugmentation demandeAugmentation)
        {
            if (demandeAugmentation.Pourcentage <= 5)
            {
                this.TraiteDemandeAugmentation(demandeAugmentation);
            }
            else
            {
                this.successor?.EtudieDemandeAugmentation(demandeAugmentation);
            }
        }

        private void TraiteDemandeAugmentation(DemandeAugmentation demandeAugmentation)
        {
            Random random = new Random();
            var randomizedNumber = random.Next(0, 101);

            Console.WriteLine(randomizedNumber < 45
                ? $"{demandeAugmentation.Demandeur}, votre {this.GetType().Name} a approuvé votre demande d'augmentation de {demandeAugmentation.Pourcentage}%. Félicitations."
                : $"{demandeAugmentation.Demandeur}, votre {this.GetType().Name} n'a pas approuvé votre demande d'augmentation de {demandeAugmentation.Pourcentage}%. Retentez votre chance.");
        }
    }
}