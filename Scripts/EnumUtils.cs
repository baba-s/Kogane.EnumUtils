using System;
using System.Linq;

namespace Kogane
{
	/// <summary>
	/// 列挙型に関する汎用関数を管理するクラス
	/// </summary>
	public static class EnumUtils
	{
		//================================================================================
		// 変数(static)
		//================================================================================
		private static Random m_random;

		//================================================================================
		// プロパティ(static)
		//================================================================================
		private static Random Random => m_random ?? ( m_random = new Random() );

		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 指定した列挙体に含まれている定数の値の配列を取得します
		/// </summary>
		public static T[] GetValues<T>()
		{
			return Enum.GetValues( typeof( T ) ) as T[];
		}

		/// <summary>
		/// 指定した列挙体に含まれている定数の名前の配列を取得します
		/// </summary>
		public static string[] GetNames<T>()
		{
			return Enum.GetNames( typeof( T ) );
		}

		/// <summary>
		/// 指定した値を持つ指定した列挙体にある定数の名前を取得します
		/// </summary>
		public static string GetName<T>( object value )
		{
			return Enum.GetName( typeof( T ), value );
		}

		/// <summary>
		/// 指定された整数値、またはその名前が文字列として指定した列挙型に存在するかどうかを示すブール値を返します
		/// </summary>
		public static bool IsDefined<T>( object value )
		{
			return Enum.IsDefined( typeof( T ), value );
		}

		/// <summary>
		/// 文字列形式での 1 つ以上の列挙定数の名前または数値を、等価の列挙オブジェクトに変換します
		/// </summary>
		public static T Parse<T>( string value )
		{
			return ( T ) Enum.Parse( typeof( T ), value );
		}

		/// <summary>
		/// 文字列形式での 1 つ以上の列挙定数の名前または数値を、等価の列挙オブジェクトに変換します
		/// 演算で大文字と小文字を区別しないかどうかをパラメーターで指定します
		/// </summary>
		public static T Parse<T>( string value, bool ignoreCase )
		{
			return ( T ) Enum.Parse( typeof( T ), value, ignoreCase );
		}

		/// <summary>
		/// 指定された文字列を列挙型に変換して成功したかどうかを返します
		/// </summary>
		public static bool TryParse<T>( string value, out T result ) where T : struct
		{
			return Enum.TryParse( value, out result );
		}

		/// <summary>
		/// 指定された文字列を列挙型に変換して成功したかどうかを返します
		/// </summary>
		public static bool TryParse<T>( string value, bool ignoreCase, out T result ) where T : struct
		{
			return Enum.TryParse( value, ignoreCase, out result );
		}

		/// <summary>
		/// 指定された列挙型の値の数を返します
		/// </summary>
		public static int GetLength<T>()
		{
			return Enum.GetValues( typeof( T ) ).Length;
		}

		/// <summary>
		/// 指定された列挙型の値をランダムに返します
		/// </summary>
		public static T RandomAt<T>( params T[] collection )
		{
			return collection
				.OrderBy( c => Random.Next() )
				.FirstOrDefault();
		}

		/// <summary>
		/// 指定された列挙型の値をランダムに返します
		/// </summary>
		public static T RandomAt<T>()
		{
			return Enum.GetValues( typeof( T ) )
				.Cast<T>()
				.OrderBy( c => Random.Next() )
				.FirstOrDefault();
		}
	}
}