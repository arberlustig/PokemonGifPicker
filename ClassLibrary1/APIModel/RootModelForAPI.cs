using System.Text.Json.Serialization;

namespace Core.APIModel
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public record Ability(
        [property: JsonPropertyName("ability")] Ability ability,
        [property: JsonPropertyName("is_hidden")] bool? is_hidden,
        [property: JsonPropertyName("slot")] int? slot
    );

    public record Ability2(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record Animated(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record BlackWhite(
        [property: JsonPropertyName("animated")] Animated animated,
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record BrilliantDiamondShiningPearl(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female
    );

    public record Cries(
        [property: JsonPropertyName("latest")] string latest,
        [property: JsonPropertyName("legacy")] string legacy
    );

    public record Crystal(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_transparent")] string back_shiny_transparent,
        [property: JsonPropertyName("back_transparent")] string back_transparent,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_transparent")] string front_shiny_transparent,
        [property: JsonPropertyName("front_transparent")] string front_transparent
    );

    public record DiamondPearl(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record DreamWorld(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female
    );

    public record Emerald(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny
    );

    public record FireredLeafgreen(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny
    );

    public record Form(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record GameIndex(
        [property: JsonPropertyName("game_index")] int? game_index,
        [property: JsonPropertyName("version")] Version version
    );

    public record Generation(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record GenerationI(
        [property: JsonPropertyName("red-blue")] RedBlue redblue,
        [property: JsonPropertyName("yellow")] Yellow yellow
    );

    public record GenerationIi(
        [property: JsonPropertyName("crystal")] Crystal crystal,
        [property: JsonPropertyName("gold")] Gold gold,
        [property: JsonPropertyName("silver")] Silver silver
    );

    public record GenerationIii(
        [property: JsonPropertyName("emerald")] Emerald emerald,
        [property: JsonPropertyName("firered-leafgreen")] FireredLeafgreen fireredleafgreen,
        [property: JsonPropertyName("ruby-sapphire")] RubySapphire rubysapphire
    );

    public record GenerationIv(
        [property: JsonPropertyName("diamond-pearl")] DiamondPearl diamondpearl,
        [property: JsonPropertyName("heartgold-soulsilver")] HeartgoldSoulsilver heartgoldsoulsilver,
        [property: JsonPropertyName("platinum")] Platinum platinum
    );

    public record GenerationIx(
        [property: JsonPropertyName("scarlet-violet")] ScarletViolet scarletviolet
    );

    public record GenerationV(
        [property: JsonPropertyName("black-white")] BlackWhite blackwhite
    );

    public record GenerationVi(
        [property: JsonPropertyName("omegaruby-alphasapphire")] OmegarubyAlphasapphire omegarubyalphasapphire,
        [property: JsonPropertyName("x-y")] XY xy
    );

    public record GenerationVii(
        [property: JsonPropertyName("icons")] Icons icons,
        [property: JsonPropertyName("ultra-sun-ultra-moon")] UltraSunUltraMoon ultrasunultramoon
    );

    public record GenerationViii(
        [property: JsonPropertyName("brilliant-diamond-shining-pearl")] BrilliantDiamondShiningPearl brilliantdiamondshiningpearl,
        [property: JsonPropertyName("icons")] Icons icons
    );

    public record Gold(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_transparent")] string front_transparent
    );

    public record HeartgoldSoulsilver(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record HeldItem(
        [property: JsonPropertyName("item")] Item item,
        [property: JsonPropertyName("version_details")] IReadOnlyList<VersionDetail> version_details
    );

    public record Home(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record Icons(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female
    );

    public record Item(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record Move(
        [property: JsonPropertyName("move")] Move move,
        [property: JsonPropertyName("version_group_details")] IReadOnlyList<VersionGroupDetail> version_group_details
    );

    public record Move2(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record MoveLearnMethod(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record OfficialArtwork(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny
    );

    public record OmegarubyAlphasapphire(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record Other(
        [property: JsonPropertyName("dream_world")] DreamWorld dream_world,
        [property: JsonPropertyName("home")] Home home,
        [property: JsonPropertyName("official-artwork")] OfficialArtwork officialartwork,
        [property: JsonPropertyName("showdown")] Showdown showdown
    );

    public record PastAbility(
        [property: JsonPropertyName("abilities")] IReadOnlyList<Ability> abilities,
        [property: JsonPropertyName("generation")] Generation generation
    );

    public record PastStat(
        [property: JsonPropertyName("generation")] Generation generation,
        [property: JsonPropertyName("stats")] IReadOnlyList<Stat> stats
    );

    public record Platinum(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record RedBlue(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_gray")] string back_gray,
        [property: JsonPropertyName("back_transparent")] string back_transparent,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_gray")] string front_gray,
        [property: JsonPropertyName("front_transparent")] string front_transparent
    );

    public record Root(
        [property: JsonPropertyName("abilities")] IReadOnlyList<Ability> abilities,
        [property: JsonPropertyName("base_experience")] int? base_experience,
        [property: JsonPropertyName("cries")] Cries cries,
        [property: JsonPropertyName("forms")] IReadOnlyList<Form> forms,
        [property: JsonPropertyName("game_indices")] IReadOnlyList<GameIndex> game_indices,
        [property: JsonPropertyName("height")] int? height,
        [property: JsonPropertyName("held_items")] IReadOnlyList<HeldItem> held_items,
        [property: JsonPropertyName("id")] int? id,
        [property: JsonPropertyName("is_default")] bool? is_default,
        [property: JsonPropertyName("location_area_encounters")] string location_area_encounters,
        [property: JsonPropertyName("moves")] IReadOnlyList<Move> moves,
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("order")] int? order,
        [property: JsonPropertyName("past_abilities")] IReadOnlyList<PastAbility> past_abilities,
        [property: JsonPropertyName("past_stats")] IReadOnlyList<PastStat> past_stats,
        [property: JsonPropertyName("past_types")] IReadOnlyList<object> past_types,
        [property: JsonPropertyName("species")] Species species,
        [property: JsonPropertyName("sprites")] Sprites sprites,
        [property: JsonPropertyName("stats")] IReadOnlyList<Stat> stats,
        [property: JsonPropertyName("types")] IReadOnlyList<Type> types,
        [property: JsonPropertyName("weight")] int? weight
    );

    public record RubySapphire(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny
    );

    public record ScarletViolet(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female
    );

    public record Showdown(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record Silver(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_transparent")] string front_transparent
    );

    public record Species(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record Sprites(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_female")] object back_female,
        [property: JsonPropertyName("back_shiny")] string back_shiny,
        [property: JsonPropertyName("back_shiny_female")] object back_shiny_female,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female,
        [property: JsonPropertyName("other")] Other other,
        [property: JsonPropertyName("versions")] Versions versions
    );

    public record Stat(
        [property: JsonPropertyName("base_stat")] int? base_stat,
        [property: JsonPropertyName("effort")] int? effort,
        [property: JsonPropertyName("stat")] Stat stat
    );

    public record Stat2(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record Type(
        [property: JsonPropertyName("slot")] int? slot,
        [property: JsonPropertyName("type")] Type type
    );

    public record Type2(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record UltraSunUltraMoon(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record Version(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record VersionDetail(
        [property: JsonPropertyName("rarity")] int? rarity,
        [property: JsonPropertyName("version")] Version version
    );

    public record VersionGroup(
        [property: JsonPropertyName("name")] string name,
        [property: JsonPropertyName("url")] string url
    );

    public record VersionGroupDetail(
        [property: JsonPropertyName("level_learned_at")] int? level_learned_at,
        [property: JsonPropertyName("move_learn_method")] MoveLearnMethod move_learn_method,
        [property: JsonPropertyName("order")] object order,
        [property: JsonPropertyName("version_group")] VersionGroup version_group
    );

    public record Versions(
        [property: JsonPropertyName("generation-i")] GenerationI generationi,
        [property: JsonPropertyName("generation-ii")] GenerationIi generationii,
        [property: JsonPropertyName("generation-iii")] GenerationIii generationiii,
        [property: JsonPropertyName("generation-iv")] GenerationIv generationiv,
        [property: JsonPropertyName("generation-ix")] GenerationIx generationix,
        [property: JsonPropertyName("generation-v")] GenerationV generationv,
        [property: JsonPropertyName("generation-vi")] GenerationVi generationvi,
        [property: JsonPropertyName("generation-vii")] GenerationVii generationvii,
        [property: JsonPropertyName("generation-viii")] GenerationViii generationviii
    );

    public record XY(
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_female")] object front_female,
        [property: JsonPropertyName("front_shiny")] string front_shiny,
        [property: JsonPropertyName("front_shiny_female")] object front_shiny_female
    );

    public record Yellow(
        [property: JsonPropertyName("back_default")] string back_default,
        [property: JsonPropertyName("back_gray")] string back_gray,
        [property: JsonPropertyName("back_transparent")] string back_transparent,
        [property: JsonPropertyName("front_default")] string front_default,
        [property: JsonPropertyName("front_gray")] string front_gray,
        [property: JsonPropertyName("front_transparent")] string front_transparent
    );


}
