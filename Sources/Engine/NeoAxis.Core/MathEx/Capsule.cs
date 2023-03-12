// Copyright (C) NeoAxis Group Ltd. 8 Copthall, Roseau Valley, 00152 Commonwealth of Dominica.
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace NeoAxis
{
	//[TypeConverter( typeof( MathExGeneralTypeConverter<Capsule> ) )]
	/// <summary>
	/// Represents a double precision capsule shape.
	/// </summary>
	[StructLayout( LayoutKind.Sequential )]
	public struct Capsule
	{
		[Serialize]
		public Vector3 Point1;
		[Serialize]
		public Vector3 Point2;
		[Serialize]
		public double Radius;

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public Capsule( Capsule source )
		{
			Point1 = source.Point1;
			Point2 = source.Point2;
			Radius = source.Radius;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public Capsule( Vector3 point1, Vector3 point2, double radius )
		{
			this.Point1 = point1;
			this.Point2 = point2;
			this.Radius = radius;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public override bool Equals( object obj )
		{
			return ( obj is Capsule && this == (Capsule)obj );
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public override int GetHashCode()
		{
			return ( Point1.GetHashCode() ^ Point2.GetHashCode() ^ Radius.GetHashCode() );
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public static bool operator ==( Capsule v1, Capsule v2 )
		{
			return ( v1.Point1 == v2.Point1 && v1.Point2 == v2.Point2 && v1.Radius == v2.Radius );
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public static bool operator !=( Capsule v1, Capsule v2 )
		{
			return ( v1.Point1 != v2.Point1 || v1.Point2 != v2.Point2 || v1.Radius != v2.Radius );
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public bool Equals( Capsule v, double epsilon )
		{
			if( !Point1.Equals( ref v.Point1, epsilon ) )
				return false;
			if( !Point2.Equals( ref v.Point2, epsilon ) )
				return false;
			if( Math.Abs( Radius - v.Radius ) > epsilon )
				return false;
			return true;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public Bounds ToBounds()
		{
			Bounds result = new Bounds( Point1 );
			result.Add( Point2 );
			result.Expand( Radius );
			return result;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public void ToBounds( out Bounds result )
		{
			result = new Bounds( Point1 );
			result.Add( Point2 );
			result.Expand( Radius );
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public Vector3 GetCenter()
		{
			Vector3 result;
			Vector3.Add( ref Point1, ref Point2, out result );
			result.X *= .5;
			result.Y *= .5;
			result.Z *= .5;
			return result;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public void GetCenter( out Vector3 result )
		{
			Vector3.Add( ref Point1, ref Point2, out result );
			result.X *= .5;
			result.Y *= .5;
			result.Z *= .5;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public double GetLength()
		{
			Vector3 result;
			Vector3.Subtract( ref Point2, ref Point1, out result );
			return result.Length();
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public Vector3 GetDirection()
		{
			Vector3 result;
			Vector3.Subtract( ref Point2, ref Point1, out result );
			result.Normalize();
			return result;
		}

		[MethodImpl( MethodImplOptions.AggressiveInlining | (MethodImplOptions)512 )]
		public void GetDirection( out Vector3 result )
		{
			Vector3.Subtract( ref Point2, ref Point1, out result );
			result.Normalize();
		}

		[MethodImpl( (MethodImplOptions)512 )]
		public bool Contains( Vector3 point )
		{
			if( Point1 != Point2 )
			{
				double radiusSquared = Radius * Radius;

				if( ( Point1 - point ).LengthSquared() <= radiusSquared )
					return true;
				if( ( Point2 - point ).LengthSquared() <= radiusSquared )
					return true;

				Vector3 projectPoint;
				MathAlgorithms.ProjectPointToLine( ref Point1, ref Point2, ref point, out projectPoint );

				Bounds pointsBounds = new Bounds( Point1 );
				pointsBounds.Add( Point2 );

				if( pointsBounds.Contains( projectPoint ) )
				{
					if( ( projectPoint - point ).LengthSquared() <= radiusSquared )
						return true;
				}

				return false;
			}
			else
			{
				return new Sphere( Point1, Radius ).Contains( point );
			}
		}

		//!!!!
		//[AutoConvertType]
		//Parse, ToString

	}
}
