using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class ModifiedHoldingPen : HoldingPen
    {
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
            
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            string unitName = commandWords[2];

            switch (commandWords[1])
            {
                case "Weapon":
                    GetUnit(unitName).AddSupplement(new Weapon());
                    break;
                case "PowerInhibitor":
                    GetUnit(unitName).AddSupplement(new PowerInhibitor());
                    break;
                case "HealthInhibitor":
                    GetUnit(unitName).AddSupplement(new HealthInhibitor());
                    break;
                case "AggressionInhibitor":
                    GetUnit(unitName).AddSupplement(new AggressionInhibitor());
                    break;
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit infestationUnit = this.GetUnit(interaction.TargetUnit);

                    infestationUnit.AddSupplement(new InfestationSpores());
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }
    }
}
