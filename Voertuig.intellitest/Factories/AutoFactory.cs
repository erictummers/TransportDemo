using Voertuig;
using System;
using Microsoft.Pex.Framework;

namespace Voertuig
{
    /// <summary>A factory for Voertuig.Auto instances</summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static partial class AutoFactory
    {
        /// <summary>A factory for Voertuig.Auto instances</summary>
        [PexFactoryMethod(typeof(Auto))]
        public static Auto Create([PexAssumeNotNull]Verplaatsing verplaatsing, string bestuurder)
        {
            Auto auto = new Auto
            {
                Verplaatsing = verplaatsing,
                Bestuurder = bestuurder
            };
            return auto;

            // TODO: Edit factory method of Auto
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
