# UnityParticleLesson
- 社内勉強会用

## VFXとは
[Wikipedia](https://ja.wikipedia.org/wiki/VFX)より
```
VFX（ブイエフエックス）とは、Visual Effects（ビジュアル・エフェクツ）の略で
特撮を用いた映画やテレビドラマにおいて、現実には見ることのできない画面効果を
実現するための技術のことを指す。視覚効果（しかくこうか）ともいう。
```

## UnityにおけるVFXの用意
- Unity上で提供されているパーティクルシステム「Shuriken」で作成
- [AssetStore](https://www.assetstore.unity3d.com/jp/#!/search/page=1/sortby=popularity/query=category:125) からプリセットを購入する
- AssetStoreからUnity上で機能するパーティクルエディタを購入する
  - [エディターセレクション – イカしたパーティクルをご紹介！](http://blogs.unity3d.com/jp/2015/11/18/editors-picks-the-particulars-of-particles/)
  - [ParticlePlayGround](https://www.assetstore.unity3d.com/jp/#!/content/13325) (Shurikenの拡張)
  - [FX Maker](https://www.assetstore.unity3d.com/jp/#!/content/4580)
  - [PopcornFX](https://www.assetstore.unity3d.com/jp/#!/content/25913)
- 外部ツールで作ってUnityで取り込む
  - [BISHAMON](http://www.matchlock.co.jp/products/)
  - [AfterEffect](http://www.adobe.com/jp/products/aftereffects.htm)

## Particleとは
[ASCII.jpデジタル用語辞典](https://kotobank.jp/word/%E3%83%91%E3%83%BC%E3%83%86%E3%82%A3%E3%82%AF%E3%83%AB-11737)より
```
3Dグラフィックのモデリング技法のひとつ。
自然界に存在する複雑で不規則な形状をしている
火、煙、雲、霧、草、髪などを表現するために考案された。
このようなポリゴンや曲面だけでは表現し切れない形状を
微小な粒子の集まりとして記述し、それが動き回る様を確率モデルとして処理する。
```

## Shurikenとは
- Unity3.5から搭載されたパーティクルシステム
- 参考資料
  - https://speakerdeck.com/unitydojo/21unitydao-chang-pateikurujiang-zuo
  - http://docs.unity3d.com/ja/current/Manual/class-ParticleSystem.html
  - http://qiita.com/nenjiru/items/04d5dc9f518125394b19

## Shurikenをいじる
- (Unity外) Textureを作成する
- Materialを作成する
  - "Project" => "Create" => "Material"
  - "Shader" を "Particle" => "Additive" (加算合成) に設定
    - カスタマイズしたい場合は自分でシェーダープログラム書くこと
- Particleを作成
  - Unityエディタ上部メニュー "GameObject" => "Particle System" 
- Particleの各種設定を変更する

## 爆発を作る
- FIXME

## FAQ
### 良いパーティクルを作るコツ
- 「分解」と「再構築」
  - [Unity ゲームエフェクト入門 Shurikenで作る！ユーザーを引き込む演出手法](http://www.shoeisha.co.jp/book/detail/9784798144122)より
  - 演出は複数の細かい効果の組み合わせ
  - 色んな映像を見て、どういう要素で成り立っているか考える

### Shurikenが重い
- 大きめに / 少なめにを心がければ軽くなる
- もしくはSpriteAnimationに変換して使う
  - https://www.assetstore.unity3d.com/jp/#!/content/3716
- CPUベースでの使用を避ける
  - http://tsubakit1.hateblo.jp/

### 大きさ変更はどうすれば？
- Shuriken側のSizeで調整
  - http://posposi.blog.fc2.com/blog-entry-292.html
- [Particle Scaler](https://www.assetstore.unity3d.com/jp/#!/content/4400)を使う
