# Bavarois

## 開発する上での注意

### フォルダの詳細
Assets/Scenes：シーンのデータを入れます。  
Assets/Scripts：C#のスクリプトは基本ここに入れましょう。適宜さらに下の階層にフォルダを作ってスクリプトを分けてもいいかもしれません。  
Assets/Image：画像データはここに入れましょう。ガチャの景品として得られるペットの絵の画像を入れたりします。  
Assets/Prefabs：色んなところで流用するオブジェクトをここにまとめておくとラクです。たとえばシーン遷移のプログラムがアタッチされたボタンオブジェクトとかを保存しておくといちいち作る必要がなくなります。  

### セーブ機能
データのセーブ機能を追加しました。DataManagerというオブジェクトがグローバルで共有されるようになっており、DataManagerのメソッドを呼び出すことによりデータをJSONファイルから取り出せるようになっています。Assetフォルダ直下にsavedata.jsonというJSONファイルがあり、そこにデータが格納されています。  

#### データの設定  
Scriptsフォルダの中に、SaveData.csというファイルがあります。中身は現時点で以下のようになっています。  
```
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using System.IO;  
  
[System.Serializable]  
public class SaveData  
{  
    public int usedMoney;  
    public int collection;  
}  
```
現在はusedMoney、collectionというデータのみを格納していますが、ここをもっと詳細にするイメージです。

#### データのロード
DataManagerにLoadという関数があり、  
`SaveData saveData = DataManager.instance.Load();`  
と書くことで、saveDataにデータが格納されます。  

#### データの更新
データが格納されている変数を変えるだけです。例えば、使用したお金を1000円増やしたい場合には、  
`saveData.usedMoney += 1000;`とします。

#### データの保存
DataManagerにSaveという関数があり、  
`DataManager.instance.Save(saveData);`  
と書くことで、saveDataがJSONファイルに保存されます。
