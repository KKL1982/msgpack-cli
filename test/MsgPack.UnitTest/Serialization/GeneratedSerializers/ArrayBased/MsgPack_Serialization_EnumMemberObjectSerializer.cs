﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_EnumMemberObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumMemberObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumByName> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumByName> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumByName> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumByUnderlyingValue> _serializer3;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumByUnderlyingValue> _serializer4;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumByUnderlyingValue> _serializer5;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumDefault> _serializer6;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumDefault> _serializer7;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.EnumDefault> _serializer8;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumByName>> _serializer9;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumByName>> _serializer10;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumByName>> _serializer11;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>> _serializer12;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>> _serializer13;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>> _serializer14;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumDefault>> _serializer15;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumDefault>> _serializer16;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<MsgPack.Serialization.EnumDefault>> _serializer17;
        
        public MsgPack_Serialization_EnumMemberObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = context.GetSerializer<MsgPack.Serialization.EnumByName>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumByName), MsgPack.Serialization.EnumMemberSerializationMethod.ByName));
            this._serializer1 = context.GetSerializer<MsgPack.Serialization.EnumByName>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumByName), MsgPack.Serialization.EnumMemberSerializationMethod.ByUnderlyingValue));
            this._serializer2 = context.GetSerializer<MsgPack.Serialization.EnumByName>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumByName), MsgPack.Serialization.EnumMemberSerializationMethod.Default));
            this._serializer3 = context.GetSerializer<MsgPack.Serialization.EnumByUnderlyingValue>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumByUnderlyingValue), MsgPack.Serialization.EnumMemberSerializationMethod.ByName));
            this._serializer4 = context.GetSerializer<MsgPack.Serialization.EnumByUnderlyingValue>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumByUnderlyingValue), MsgPack.Serialization.EnumMemberSerializationMethod.ByUnderlyingValue));
            this._serializer5 = context.GetSerializer<MsgPack.Serialization.EnumByUnderlyingValue>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumByUnderlyingValue), MsgPack.Serialization.EnumMemberSerializationMethod.Default));
            this._serializer6 = context.GetSerializer<MsgPack.Serialization.EnumDefault>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumDefault), MsgPack.Serialization.EnumMemberSerializationMethod.ByName));
            this._serializer7 = context.GetSerializer<MsgPack.Serialization.EnumDefault>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumDefault), MsgPack.Serialization.EnumMemberSerializationMethod.ByUnderlyingValue));
            this._serializer8 = context.GetSerializer<MsgPack.Serialization.EnumDefault>(MsgPack.Serialization.EnumMessagePackSerializerHelpers.DetermineEnumSerializationMethod(context, typeof(MsgPack.Serialization.EnumDefault), MsgPack.Serialization.EnumMemberSerializationMethod.Default));
            this._serializer9 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumByName>>();
            this._serializer10 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumByName>>();
            this._serializer11 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumByName>>();
            this._serializer12 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>>();
            this._serializer13 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>>();
            this._serializer14 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>>();
            this._serializer15 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumDefault>>();
            this._serializer16 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumDefault>>();
            this._serializer17 = context.GetSerializer<System.Nullable<MsgPack.Serialization.EnumDefault>>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.EnumMemberObject objectTree) {
            packer.PackArrayHeader(9);
            this._serializer0.PackTo(packer, objectTree.ByNameByNameProperty);
            this._serializer1.PackTo(packer, objectTree.ByNameByUnderlyingValueProperty);
            this._serializer2.PackTo(packer, objectTree.ByNameDefaultProperty);
            this._serializer3.PackTo(packer, objectTree.ByUnderlyingValueByNameProperty);
            this._serializer4.PackTo(packer, objectTree.ByUnderlyingValueByUnderlyingValueProperty);
            this._serializer5.PackTo(packer, objectTree.ByUnderlyingValueDefaultProperty);
            this._serializer6.PackTo(packer, objectTree.DefaultByNameProperty);
            this._serializer7.PackTo(packer, objectTree.DefaultByUnderlyingValueProperty);
            this._serializer8.PackTo(packer, objectTree.DefaultDefaultProperty);
        }
        
        protected internal override MsgPack.Serialization.EnumMemberObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.EnumMemberObject result = default(MsgPack.Serialization.EnumMemberObject);
            result = new MsgPack.Serialization.EnumMemberObject();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Nullable<MsgPack.Serialization.EnumByName> nullable = default(System.Nullable<MsgPack.Serialization.EnumByName>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer9.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer9.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (nullable.HasValue) {
                    result.ByNameByNameProperty = nullable.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumByName> nullable0 = default(System.Nullable<MsgPack.Serialization.EnumByName>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(1);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable0 = this._serializer10.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try {
                            nullable0 = this._serializer10.UnpackFrom(disposable0);
                        }
                        finally {
                            if (((disposable0 == null) 
                                        == false)) {
                                disposable0.Dispose();
                            }
                        }
                    }
                }
                if (nullable0.HasValue) {
                    result.ByNameByUnderlyingValueProperty = nullable0.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumByName> nullable1 = default(System.Nullable<MsgPack.Serialization.EnumByName>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(2);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable1 = this._serializer11.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                        disposable1 = unpacker.ReadSubtree();
                        try {
                            nullable1 = this._serializer11.UnpackFrom(disposable1);
                        }
                        finally {
                            if (((disposable1 == null) 
                                        == false)) {
                                disposable1.Dispose();
                            }
                        }
                    }
                }
                if (nullable1.HasValue) {
                    result.ByNameDefaultProperty = nullable1.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue> nullable2 = default(System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(3);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable2 = this._serializer12.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                        disposable2 = unpacker.ReadSubtree();
                        try {
                            nullable2 = this._serializer12.UnpackFrom(disposable2);
                        }
                        finally {
                            if (((disposable2 == null) 
                                        == false)) {
                                disposable2.Dispose();
                            }
                        }
                    }
                }
                if (nullable2.HasValue) {
                    result.ByUnderlyingValueByNameProperty = nullable2.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue> nullable3 = default(System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(4);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable3 = this._serializer13.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable3 = default(MsgPack.Unpacker);
                        disposable3 = unpacker.ReadSubtree();
                        try {
                            nullable3 = this._serializer13.UnpackFrom(disposable3);
                        }
                        finally {
                            if (((disposable3 == null) 
                                        == false)) {
                                disposable3.Dispose();
                            }
                        }
                    }
                }
                if (nullable3.HasValue) {
                    result.ByUnderlyingValueByUnderlyingValueProperty = nullable3.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue> nullable4 = default(System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(5);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable4 = this._serializer14.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                        disposable4 = unpacker.ReadSubtree();
                        try {
                            nullable4 = this._serializer14.UnpackFrom(disposable4);
                        }
                        finally {
                            if (((disposable4 == null) 
                                        == false)) {
                                disposable4.Dispose();
                            }
                        }
                    }
                }
                if (nullable4.HasValue) {
                    result.ByUnderlyingValueDefaultProperty = nullable4.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumDefault> nullable5 = default(System.Nullable<MsgPack.Serialization.EnumDefault>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(6);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable5 = this._serializer15.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable5 = default(MsgPack.Unpacker);
                        disposable5 = unpacker.ReadSubtree();
                        try {
                            nullable5 = this._serializer15.UnpackFrom(disposable5);
                        }
                        finally {
                            if (((disposable5 == null) 
                                        == false)) {
                                disposable5.Dispose();
                            }
                        }
                    }
                }
                if (nullable5.HasValue) {
                    result.DefaultByNameProperty = nullable5.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumDefault> nullable6 = default(System.Nullable<MsgPack.Serialization.EnumDefault>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(7);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable6 = this._serializer16.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable6 = default(MsgPack.Unpacker);
                        disposable6 = unpacker.ReadSubtree();
                        try {
                            nullable6 = this._serializer16.UnpackFrom(disposable6);
                        }
                        finally {
                            if (((disposable6 == null) 
                                        == false)) {
                                disposable6.Dispose();
                            }
                        }
                    }
                }
                if (nullable6.HasValue) {
                    result.DefaultByUnderlyingValueProperty = nullable6.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<MsgPack.Serialization.EnumDefault> nullable7 = default(System.Nullable<MsgPack.Serialization.EnumDefault>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(8);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable7 = this._serializer17.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable7 = default(MsgPack.Unpacker);
                        disposable7 = unpacker.ReadSubtree();
                        try {
                            nullable7 = this._serializer17.UnpackFrom(disposable7);
                        }
                        finally {
                            if (((disposable7 == null) 
                                        == false)) {
                                disposable7.Dispose();
                            }
                        }
                    }
                }
                if (nullable7.HasValue) {
                    result.DefaultDefaultProperty = nullable7.Value;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable8 = default(string);
                    nullable8 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.EnumMemberObject), "MemberName");
                    if (((nullable8 == null) 
                                == false)) {
                        key = nullable8;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "DefaultDefaultProperty")) {
                        System.Nullable<MsgPack.Serialization.EnumDefault> nullable17 = default(System.Nullable<MsgPack.Serialization.EnumDefault>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable17 = this._serializer17.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable16 = default(MsgPack.Unpacker);
                            disposable16 = unpacker.ReadSubtree();
                            try {
                                nullable17 = this._serializer17.UnpackFrom(disposable16);
                            }
                            finally {
                                if (((disposable16 == null) 
                                            == false)) {
                                    disposable16.Dispose();
                                }
                            }
                        }
                        if (nullable17.HasValue) {
                            result.DefaultDefaultProperty = nullable17.Value;
                        }
                    }
                    else {
                        if ((key == "DefaultByUnderlyingValueProperty")) {
                            System.Nullable<MsgPack.Serialization.EnumDefault> nullable16 = default(System.Nullable<MsgPack.Serialization.EnumDefault>);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable16 = this._serializer16.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable15 = default(MsgPack.Unpacker);
                                disposable15 = unpacker.ReadSubtree();
                                try {
                                    nullable16 = this._serializer16.UnpackFrom(disposable15);
                                }
                                finally {
                                    if (((disposable15 == null) 
                                                == false)) {
                                        disposable15.Dispose();
                                    }
                                }
                            }
                            if (nullable16.HasValue) {
                                result.DefaultByUnderlyingValueProperty = nullable16.Value;
                            }
                        }
                        else {
                            if ((key == "DefaultByNameProperty")) {
                                System.Nullable<MsgPack.Serialization.EnumDefault> nullable15 = default(System.Nullable<MsgPack.Serialization.EnumDefault>);
                                if ((unpacker.Read() == false)) {
                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                }
                                if (((unpacker.IsArrayHeader == false) 
                                            && (unpacker.IsMapHeader == false))) {
                                    nullable15 = this._serializer15.UnpackFrom(unpacker);
                                }
                                else {
                                    MsgPack.Unpacker disposable14 = default(MsgPack.Unpacker);
                                    disposable14 = unpacker.ReadSubtree();
                                    try {
                                        nullable15 = this._serializer15.UnpackFrom(disposable14);
                                    }
                                    finally {
                                        if (((disposable14 == null) 
                                                    == false)) {
                                            disposable14.Dispose();
                                        }
                                    }
                                }
                                if (nullable15.HasValue) {
                                    result.DefaultByNameProperty = nullable15.Value;
                                }
                            }
                            else {
                                if ((key == "ByUnderlyingValueDefaultProperty")) {
                                    System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue> nullable14 = default(System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>);
                                    if ((unpacker.Read() == false)) {
                                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                    }
                                    if (((unpacker.IsArrayHeader == false) 
                                                && (unpacker.IsMapHeader == false))) {
                                        nullable14 = this._serializer14.UnpackFrom(unpacker);
                                    }
                                    else {
                                        MsgPack.Unpacker disposable13 = default(MsgPack.Unpacker);
                                        disposable13 = unpacker.ReadSubtree();
                                        try {
                                            nullable14 = this._serializer14.UnpackFrom(disposable13);
                                        }
                                        finally {
                                            if (((disposable13 == null) 
                                                        == false)) {
                                                disposable13.Dispose();
                                            }
                                        }
                                    }
                                    if (nullable14.HasValue) {
                                        result.ByUnderlyingValueDefaultProperty = nullable14.Value;
                                    }
                                }
                                else {
                                    if ((key == "ByUnderlyingValueByUnderlyingValueProperty")) {
                                        System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue> nullable13 = default(System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>);
                                        if ((unpacker.Read() == false)) {
                                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                        }
                                        if (((unpacker.IsArrayHeader == false) 
                                                    && (unpacker.IsMapHeader == false))) {
                                            nullable13 = this._serializer13.UnpackFrom(unpacker);
                                        }
                                        else {
                                            MsgPack.Unpacker disposable12 = default(MsgPack.Unpacker);
                                            disposable12 = unpacker.ReadSubtree();
                                            try {
                                                nullable13 = this._serializer13.UnpackFrom(disposable12);
                                            }
                                            finally {
                                                if (((disposable12 == null) 
                                                            == false)) {
                                                    disposable12.Dispose();
                                                }
                                            }
                                        }
                                        if (nullable13.HasValue) {
                                            result.ByUnderlyingValueByUnderlyingValueProperty = nullable13.Value;
                                        }
                                    }
                                    else {
                                        if ((key == "ByUnderlyingValueByNameProperty")) {
                                            System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue> nullable12 = default(System.Nullable<MsgPack.Serialization.EnumByUnderlyingValue>);
                                            if ((unpacker.Read() == false)) {
                                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                            }
                                            if (((unpacker.IsArrayHeader == false) 
                                                        && (unpacker.IsMapHeader == false))) {
                                                nullable12 = this._serializer12.UnpackFrom(unpacker);
                                            }
                                            else {
                                                MsgPack.Unpacker disposable11 = default(MsgPack.Unpacker);
                                                disposable11 = unpacker.ReadSubtree();
                                                try {
                                                    nullable12 = this._serializer12.UnpackFrom(disposable11);
                                                }
                                                finally {
                                                    if (((disposable11 == null) 
                                                                == false)) {
                                                        disposable11.Dispose();
                                                    }
                                                }
                                            }
                                            if (nullable12.HasValue) {
                                                result.ByUnderlyingValueByNameProperty = nullable12.Value;
                                            }
                                        }
                                        else {
                                            if ((key == "ByNameDefaultProperty")) {
                                                System.Nullable<MsgPack.Serialization.EnumByName> nullable11 = default(System.Nullable<MsgPack.Serialization.EnumByName>);
                                                if ((unpacker.Read() == false)) {
                                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                                }
                                                if (((unpacker.IsArrayHeader == false) 
                                                            && (unpacker.IsMapHeader == false))) {
                                                    nullable11 = this._serializer11.UnpackFrom(unpacker);
                                                }
                                                else {
                                                    MsgPack.Unpacker disposable10 = default(MsgPack.Unpacker);
                                                    disposable10 = unpacker.ReadSubtree();
                                                    try {
                                                        nullable11 = this._serializer11.UnpackFrom(disposable10);
                                                    }
                                                    finally {
                                                        if (((disposable10 == null) 
                                                                    == false)) {
                                                            disposable10.Dispose();
                                                        }
                                                    }
                                                }
                                                if (nullable11.HasValue) {
                                                    result.ByNameDefaultProperty = nullable11.Value;
                                                }
                                            }
                                            else {
                                                if ((key == "ByNameByUnderlyingValueProperty")) {
                                                    System.Nullable<MsgPack.Serialization.EnumByName> nullable10 = default(System.Nullable<MsgPack.Serialization.EnumByName>);
                                                    if ((unpacker.Read() == false)) {
                                                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                                    }
                                                    if (((unpacker.IsArrayHeader == false) 
                                                                && (unpacker.IsMapHeader == false))) {
                                                        nullable10 = this._serializer10.UnpackFrom(unpacker);
                                                    }
                                                    else {
                                                        MsgPack.Unpacker disposable9 = default(MsgPack.Unpacker);
                                                        disposable9 = unpacker.ReadSubtree();
                                                        try {
                                                            nullable10 = this._serializer10.UnpackFrom(disposable9);
                                                        }
                                                        finally {
                                                            if (((disposable9 == null) 
                                                                        == false)) {
                                                                disposable9.Dispose();
                                                            }
                                                        }
                                                    }
                                                    if (nullable10.HasValue) {
                                                        result.ByNameByUnderlyingValueProperty = nullable10.Value;
                                                    }
                                                }
                                                else {
                                                    if ((key == "ByNameByNameProperty")) {
                                                        System.Nullable<MsgPack.Serialization.EnumByName> nullable9 = default(System.Nullable<MsgPack.Serialization.EnumByName>);
                                                        if ((unpacker.Read() == false)) {
                                                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                                        }
                                                        if (((unpacker.IsArrayHeader == false) 
                                                                    && (unpacker.IsMapHeader == false))) {
                                                            nullable9 = this._serializer9.UnpackFrom(unpacker);
                                                        }
                                                        else {
                                                            MsgPack.Unpacker disposable8 = default(MsgPack.Unpacker);
                                                            disposable8 = unpacker.ReadSubtree();
                                                            try {
                                                                nullable9 = this._serializer9.UnpackFrom(disposable8);
                                                            }
                                                            finally {
                                                                if (((disposable8 == null) 
                                                                            == false)) {
                                                                    disposable8.Dispose();
                                                                }
                                                            }
                                                        }
                                                        if (nullable9.HasValue) {
                                                            result.ByNameByNameProperty = nullable9.Value;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
