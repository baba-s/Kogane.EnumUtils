# Kogane Enum Utils

列挙型に関する汎用関数を管理するクラス

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private enum JobType
    {
        SOLDIER,
        SORCERER,
        HUNTER,
        MERCENARY,
    }

    private void Start()
    {
        // 指定された列挙型のすべての要素を取得
        var values = EnumUtils.GetValues<JobType>();

        // 指定された列挙型のすべての要素名を取得
        var names = EnumUtils.GetNames<JobType>();

        // 指定された列挙型の要素の名前を取得
        var name = EnumUtils.GetName<JobType>( JobType.SOLDIER );
        
        // 指定された整数値もしくは名前が列挙型に存在する場合 true
        var isDefined = EnumUtils.IsDefined<JobType>( "SOLDIER" );
        
        // 指定された文字列を列挙型の要素に変換
        var parsedValue = EnumUtils.Parse<JobType>( "SOLDIER" );
        
        // 指定された文字列を列挙型の要素に変換
        if ( EnumUtils.TryParse<JobType>( "SOLDIER", out var result1 ) )
        {
        }
        
        // 指定された文字列を列挙型の要素に変換（大文字と小文字を区別しない）
        if ( EnumUtils.TryParse<JobType>( "SOLDIER", true, out var result2 ) )
        {
        }

        // 指定された列挙型の要素数を取得
        var length = EnumUtils.GetLength<JobType>();
        
        // 指定された列挙型の要素をランダムに取得
        var randomValue1 = EnumUtils.RandomAt<JobType>();
        
        // 引数に指定された列挙型の要素をランダムに取得
        var randomValue2 = EnumUtils.RandomAt( JobType.SOLDIER, JobType.SORCERER );
    }
}
```
