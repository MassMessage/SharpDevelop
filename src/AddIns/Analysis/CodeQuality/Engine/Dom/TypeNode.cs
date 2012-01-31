﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.Linq;

using ICSharpCode.NRefactory.TypeSystem;
using ICSharpCode.NRefactory.Utils;

namespace ICSharpCode.CodeQuality.Engine.Dom
{
	public class TypeNode : INode
	{
		public ITypeDefinition TypeDefinition { get; private set; }
		
		public TypeNode(ITypeDefinition typeDefinition)
		{
			this.TypeDefinition = typeDefinition;
			children = new List<INode>();
		}
		
		public string Name {
			get { return TypeDefinition.Name; }
		}
		
		List<INode> children;
		
		public IList<INode> Children {
			get { return children; }
		}
		
		public IEnumerable<INode> Descendants {
			get { return TreeTraversal.PreOrder(Children, node => node.Children); }
		}
		
		public IEnumerable<INode> Uses {
			get { return Descendants.SelectMany(node => node.Uses); }
		}
		
		public IEnumerable<INode> UsedBy {
			get { return Descendants.SelectMany(node => node.UsedBy); }
		}
		
		public Relationship GetRelationship(INode value)
		{
			Relationship r = new Relationship();
			if (value == this)
				r.AddRelationship(RelationshipType.Same);
			if (Uses.Contains(value))
				r.AddRelationship(RelationshipType.Uses);
			if (UsedBy.Contains(value))
				r.AddRelationship(RelationshipType.UsedBy);
			if (Descendants.Contains(value))
				r.AddRelationship(RelationshipType.Contains);
			return r;
		}
	}
}
