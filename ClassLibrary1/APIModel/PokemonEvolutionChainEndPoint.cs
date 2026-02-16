using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.APIModel
{
    public record EvolutionChainResponse(
        [property: JsonPropertyName("chain")] ChainLink chain
    );

    // Das ist das eigentliche Kettenglied
    public record ChainLink(
        [property: JsonPropertyName("species")] NamedApiResource species, // NamedApiResource hast du schon aus dem letzten Schritt!
        [property: JsonPropertyName("evolves_to")] IReadOnlyList<ChainLink> evolves_to
    );
}
