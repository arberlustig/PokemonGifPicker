using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Core.APIModel
{
    // Die Hauptklasse (Root)
    public record Root(
        [property: JsonPropertyName("id")] int? id,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("base_experience")] int? base_experience,
        [property: JsonPropertyName("height")] int? height,
        [property: JsonPropertyName("is_default")] bool? is_default,
        [property: JsonPropertyName("order")] int? order,
        [property: JsonPropertyName("weight")] int? weight,
        [property: JsonPropertyName("abilities")] IReadOnlyList<AbilityInfo> abilities,
        [property: JsonPropertyName("forms")] IReadOnlyList<NamedApiResource> forms,
        [property: JsonPropertyName("game_indices")] IReadOnlyList<GameIndex> game_indices,
        [property: JsonPropertyName("held_items")] IReadOnlyList<HeldItem> held_items,
        [property: JsonPropertyName("location_area_encounters")] string location_area_encounters,
        [property: JsonPropertyName("moves")] IReadOnlyList<MoveInfo> moves,
        [property: JsonPropertyName("species")] NamedApiResource species,
        [property: JsonPropertyName("sprites")] Sprites sprites,
        [property: JsonPropertyName("stats")] IReadOnlyList<StatInfo> stats,
        [property: JsonPropertyName("types")] IReadOnlyList<TypeInfo> types
    );

    // Diese Klasse ersetzt 'Ability2', 'Item', 'Species', 'Version' etc. 
    // PokeAPI nutzt dieses Name/Url-Muster extrem oft.
    public record NamedApiResource(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    // --- Sprites & Versions (Hier war das größte Chaos) ---

    public record Sprites(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("front_female")] string front_female,
        [property: JsonPropertyName("back_female")] string back_female,
        [property: JsonPropertyName("front_shiny_female")] string front_shiny_female,
        [property: JsonPropertyName("back_shiny_female")] string back_shiny_female,

        [property: JsonPropertyName("other")] OtherSprites other,

        // Die Magie: Ein Dictionary, das dynamisch alle Generationen und Spiele schluckt!
        [property: JsonPropertyName("versions")] Dictionary<string, Dictionary<string, GameSprite>> versions
    );

    public record OtherSprites(
        [property: JsonPropertyName("dream_world")] GameSprite dream_world,
        [property: JsonPropertyName("home")] GameSprite home,
        [property: JsonPropertyName("official-artwork")] GameSprite official_artwork,
        [property: JsonPropertyName("showdown")] GameSprite showdown
    );

    // Eine einzige Klasse, die ALLE Bild-Varianten abdeckt
    public record GameSprite(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("front_female")] string front_female,
        [property: JsonPropertyName("back_female")] string back_female,
        [property: JsonPropertyName("front_shiny_female")] string front_shiny_female,
        [property: JsonPropertyName("back_shiny_female")] string back_shiny_female,
        [property: JsonPropertyName("front_transparent")] string front_transparent,
        [property: JsonPropertyName("back_transparent")] string back_transparent,
        [property: JsonPropertyName("front_gray")] string front_gray,
        [property: JsonPropertyName("back_gray")] string back_gray
    );

    // --- Restliche Metadaten (sauber strukturiert) ---

    public record AbilityInfo(
        [property: JsonPropertyName("ability")] NamedApiResource ability,
        [property: JsonPropertyName("is_hidden")] bool? is_hidden,
        [property: JsonPropertyName("slot")] int? slot
    );

    public record GameIndex(
        [property: JsonPropertyName("game_index")] int? game_index,
        [property: JsonPropertyName("version")] NamedApiResource version
    );

    public record HeldItem(
        [property: JsonPropertyName("item")] NamedApiResource item,
        [property: JsonPropertyName("version_details")] IReadOnlyList<VersionDetail> version_details
    );

    public record VersionDetail(
        [property: JsonPropertyName("rarity")] int? rarity,
        [property: JsonPropertyName("version")] NamedApiResource version
    );

    public record MoveInfo(
        [property: JsonPropertyName("move")] NamedApiResource move,
        [property: JsonPropertyName("version_group_details")] IReadOnlyList<VersionGroupDetail> version_group_details
    );

    public record VersionGroupDetail(
        [property: JsonPropertyName("level_learned_at")] int? level_learned_at,
        [property: JsonPropertyName("move_learn_method")] NamedApiResource move_learn_method,
        [property: JsonPropertyName("version_group")] NamedApiResource version_group
    );

    public record StatInfo(
        [property: JsonPropertyName("base_stat")] int? base_stat,
        [property: JsonPropertyName("effort")] int? effort,
        [property: JsonPropertyName("stat")] NamedApiResource stat
    );

    public record TypeInfo(
        [property: JsonPropertyName("slot")] int? slot,
        [property: JsonPropertyName("type")] NamedApiResource type
    );
}