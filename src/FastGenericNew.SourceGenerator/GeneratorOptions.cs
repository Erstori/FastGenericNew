﻿namespace FastGenericNew.SourceGenerator;

public readonly partial record struct GeneratorOptions
{
    [GeneratorOption(16)]
    public int MaxParameterCount { get; }

    [GeneratorOption(false)]
    public bool PublicFastNewCore { get; }

    [GeneratorOption(true)]
    public bool GenerateTryCreateInstance { get; }

    [GeneratorOption(true)]
    public bool GenerateCreateInstance { get; }

    [GeneratorOption(true)]
    public bool GenerateTypeCreateInstance { get; }

    [GeneratorOption(true)]
    public bool NonPublicConstructorSupport { get; }

    [GeneratorOption("FastGenericNew")]
    public string Namespace { get; }

    [GeneratorOption(false)]
    public bool ForceFastNewDelegate { get; }

    [GeneratorOption(true)]
    public bool AlertGeneratedFile { get; }

    [GeneratorOption(false)]
    public bool DisableGeneratorCache { get; }

    [GeneratorOption(false)]
    public bool PrettyOutput { get; }

    [GeneratorOption(true)]
    public bool MultiThreadedGeneration { get; }

    [GeneratorOption(false)]
    public bool OutputGenerationInfo { get; }

    [GeneratorOption(false, PresentPreProcessor = true)]
    public bool AllowUnsafeImplementation { get; }

    [GeneratorOption(false)]
    public bool PublicFastNew { get; }

    // ctor will be generated by InternalGenerator
    //public GeneratorOptions(AnalyzerConfigOptionsProvider? provider)

    public readonly string GlobalNSDot() => string.IsNullOrWhiteSpace(Namespace)
        ? "global::@"
        : $"global::@{Namespace}.";

    public readonly string DynamicallyAccessedMembers(int argumentCount)
    {
        bool noArguments = argumentCount == 0;
        return NonPublicConstructorSupport
            ? noArguments
                ? "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor | DynamicallyAccessedMemberTypes.NonPublicConstructors)]"
                : "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)]"
            : noArguments
                ? "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]"
                : "[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]";
    }

    public readonly string PreCondition(string optionName) => $"{CodeBuilder.Const_PreProcessDefinePrefix}{optionName}";
}
