﻿using OSPSuite.Core.Commands.Core;
using PKSim.Core;
using PKSim.Core.Commands;
using PKSim.Core.Model;
using PKSim.Core.Repositories;
using PKSim.Core.Services;
using OSPSuite.Core.Importer;
using OSPSuite.Presentation.Core;

namespace PKSim.Presentation.Services
{
   public class PopulationOntogenyTask : OntogenyTask<Population>
   {
      public PopulationOntogenyTask(IExecutionContext executionContext, IApplicationController applicationController, IDataImporter dataImporter, IDimensionRepository dimensionRepository, IOntogenyRepository ontogenyRepository, IEntityTask entityTask, IFormulaFactory formulaFactory) : base(executionContext, applicationController, dataImporter, dimensionRepository, ontogenyRepository, entityTask, formulaFactory)
      {
      }

      public override ICommand SetOntogenyForMolecule(IndividualMolecule molecule, Ontogeny ontogeny, Population population)
      {
         return new SetOntogenyInMoleculeForPopulationCommand(molecule, ontogeny, population, _executionContext).Run(_executionContext);
      }
   }
}