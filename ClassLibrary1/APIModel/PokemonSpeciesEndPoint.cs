using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.APIModel
{
    // Das bekommst du von /pokemon-species/{name}
    public record SpeciesResponse(
        [property: JsonPropertyName("evolution_chain")] EvolutionChainReference evolution_chain
    );

    public record EvolutionChainReference(
        [property: JsonPropertyName("url")] string url
    );
}
