﻿using System.ComponentModel.DataAnnotations;
using T5_PR1.Models.Missatges;

namespace T5_PR1.Models
{
    public enum TipusSistema
    {
        Hidroelèctric,
        Eòlic,
        Solar
    }
    public class SistemaEnergia : ICalculSimulacio
    {
        [Required(ErrorMessage = MissatgesSistemes.RatiObligatori)]
        public float Rati { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.CostObligatori)]
        public float Cost { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.PreuObligatori)]
        public float Preu { get; set; }

        public DateTime Data { get; set; }

        [Required(ErrorMessage = MissatgesSistemes.TipusObligatori)]
        public TipusSistema? Tipus { get; set; }

        //Métodes de la classe
        /// <summary>
        /// Aquest mètode existeix a la classe abstracta perquè implementa la interfície ICalculSimulacio.
        /// Actualment retorna 0 per evitar errors de compilació, ja que les classes derivades
        /// han de proporcionar la seva pròpia implementació d'aquest mètode.
        /// </summary>
        /// <returns>Retorna 0 per defecte</returns>
        public virtual double CalcularEnergiaGenerada() => 0;


        /// <summary> Calcula el cost total de l'energia generada pel sistema eòlic. </summary>
        /// <returns> Retorna el cost total del sistema</returns>
        public virtual double CalcularCostTotal() => Math.Round(CalcularEnergiaGenerada() * Cost, 2);

        /// <summary> Calcula el preu total de l'energia generada pel sistema eòlic. </summary>
        /// <returns> Retorna el preu total del sistema</returns>
        public virtual double CalcularPreuTotal() => Math.Round(CalcularEnergiaGenerada() * Preu, 2);

        /// <summary> Calcula el benefici total de l'energia generada pel sistema eòlic. </summary>
        /// <returns> Retorna el benefici total del sistema</returns>
        public virtual double CalcularBenefici() => Math.Round(CalcularPreuTotal() - CalcularCostTotal(), 2);

    }
}
