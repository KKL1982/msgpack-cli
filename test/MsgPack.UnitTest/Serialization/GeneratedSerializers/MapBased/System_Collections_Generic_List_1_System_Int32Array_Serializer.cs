﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_Generic_List_1_System_Int32Array_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.List<int[]>> {
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer0;
        
        public System_Collections_Generic_List_1_System_Int32Array_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = context.GetSerializer<int[]>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, System.Collections.Generic.List<int[]> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.List<int[]>.Enumerator enumerator = objectTree.GetEnumerator();
            int[] current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer0.PackTo(packer, current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override System.Collections.Generic.List<int[]> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            System.Collections.Generic.List<int[]> collection = default(System.Collections.Generic.List<int[]>);
            collection = new System.Collections.Generic.List<int[]>(MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker));
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, System.Collections.Generic.List<int[]> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                int[] nullable = default(int[]);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = this._serializer0.UnpackFrom(unpacker);
                }
                else {
                    MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                    disposable = unpacker.ReadSubtree();
                    try {
                        nullable = this._serializer0.UnpackFrom(disposable);
                    }
                    finally {
                        if (((disposable == null) 
                                    == false)) {
                            disposable.Dispose();
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    collection.Add(nullable);
                }
                else {
                    collection.Add(nullable);
                }
            }
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
