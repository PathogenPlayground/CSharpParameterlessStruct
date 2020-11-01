.assembly MyStruct
{
}

.class public sequential ansi sealed beforefieldinit MyStruct extends [System.Private.CoreLib]System.ValueType
{
    .field public string Message

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        ldarg.0
        ldstr "Initialized from parameterless constructor."
        stfld string MyStruct::Message
        ret
    }

    .method public hidebysig specialname rtspecialname instance void .ctor (string message) cil managed 
    {
        .maxstack 8
        ldarg.0
        ldarg.1
        stfld string MyStruct::Message
        ret
    }

    .method public hidebysig virtual instance string ToString () cil managed 
    {
        .maxstack 8
        ldarg.0
        ldfld string MyStruct::Message
        dup
        brtrue.s END

        pop
        ldstr "Defaulted struct."

        END: ret
    }
}
