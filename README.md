# Bavarois

## 開発する上での注意

### フォルダの詳細
Assets/Scenes：シーンのデータを入れます。  
Assets/Scripts：C#のスクリプトは基本ここに入れましょう。適宜さらに下の階層にフォルダを作ってスクリプトを分けてもいいかもしれません。  
Assets/Image：画像データはここに入れましょう。ガチャの景品として得られるペットの絵の画像を入れたりします。  
Assets/Prefabs：色んなところで流用するオブジェクトをここにまとめておくとラクです。たとえばシーン遷移のプログラムがアタッチされたボタンオブジェクトとかを保存しておくといちいち作る必要がなくなります。  

### コレクションデータのクラス  
コレクションの情報をAssets/CollectionDataのフォルダに一式まとめました。  
各フォルダに犬、猫、鳥、爬虫類、オリジナルがそれぞれ5つインスタンス化されていて、それらを全部配列として格納したのがCollectionArraySOというものです。  
(SOというのはScriptable Objectの略で、実際これらのオブジェクト生成にScriptable Objectというものを使用しています。詳しく知りたい人は調べてみてください！)  

#### コレクションデータの参照方法
変数宣言をする箇所で、  
`[SerializeField] private CollectionArraySO collectionArray;`  
と宣言してみてください。最後のcollectionArrayは好きに命名してもらって大丈夫です。  
その後、例えば0から数えて4番目の犬を参照したい場合は、  
`collectionArray.dogArray[4]`  
という書き方で参照できます。この犬の名前を参照したい場合は、  
`collectionArray.dogArray[4].collectionName`  
となります。現在コレクションクラスのプロパティにはstring型のcollectionName,画像データのimageがあります。ここら辺の設定はCollectionSO.csというスクリプトで設定しています。  

もう一つやらないといけないこととして、collectionArrayをアタッチするという作業があります。  
コレクションデータを参照したスクリプトをアタッチした箇所を見てもらうと、以下のようにCollection Arrayという欄が追加されていると思います。  
![image](https://user-images.githubusercontent.com/82635302/144706584-7395ec4a-6a37-4c00-a396-8be353ee68dc.png)  
ここが「なし」のままになっているとエラーが出るので、右の◎ボタンから、CollectionArraySOを選択しましょう。  


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
