#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010-2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.Reflection;
#if FEATURE_TAP
using System.Threading;
#endif // FEATURE_TAP

namespace MsgPack.Serialization.Metadata
{
	internal static class _Packer
	{
		public static readonly MethodInfo PackArrayHeader = FromExpression.ToMethod( ( Packer packer, int count ) => packer.PackArrayHeader( count ) );
		public static readonly MethodInfo PackMapHeader = FromExpression.ToMethod( ( Packer packer, int count ) => packer.PackMapHeader( count ) );
		public static readonly MethodInfo PackNull = FromExpression.ToMethod( ( Packer packer ) => packer.PackNull() );
#if FEATURE_TAP
		public static readonly MethodInfo PackNullAsync = FromExpression.ToMethod( ( Packer packer, CancellationToken cancellationToken ) => packer.PackNullAsync( cancellationToken ) );
#endif // FEATURE_TAP
	}
}
