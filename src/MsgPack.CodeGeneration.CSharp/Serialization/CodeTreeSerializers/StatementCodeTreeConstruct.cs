﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2016 FUJIWARA, Yusuke
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
using System.Collections.Generic;
using System.Linq;

#if CSHARP
using Microsoft.CodeAnalysis.CSharp.Syntax;
#elif VISUAL_BASIC
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
#endif

namespace MsgPack.Serialization.CodeTreeSerializers
{
	internal sealed class StatementCodeTreeConstruct : CodeTreeConstruct
	{
		private readonly StatementSyntax[] _statements;

		public override bool IsStatement => true;

		public StatementCodeTreeConstruct( IEnumerable<StatementSyntax> statements )
			: base( typeof( void ) )
		{
			this._statements = statements.ToArray();
		}

		public override IEnumerable<StatementSyntax> AsStatements() => this._statements;

		public override string ToString() => $"[{String.Join( ", ", this._statements as IEnumerable<StatementSyntax> )}]";
	}
}