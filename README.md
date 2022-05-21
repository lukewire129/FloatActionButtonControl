# FloatActionButtonControl

해당 프로젝트는 

Maui
 - 정상 동작
 
Xamarin Forms
 - 다른 깃허브 저장소로 공개 (https://github.com/Luke-leeCoder/FABControl_XamarinForms.git)

# 동작GIF
[Scale1]

![Scale1](https://user-images.githubusercontent.com/54387261/169631937-51dee643-9d65-4795-8d2f-b59df8802d8f.gif)

[Sclae2]

![Scale2](https://user-images.githubusercontent.com/54387261/169632014-40669d55-efdd-4161-8e12-c35c4b2c0df9.gif)

# 문제1

![image](https://user-images.githubusercontent.com/54387261/169631346-ea87ca09-83d5-49e0-bc27-b2c0fc1cf370.png)

AnimationStyle의 값을 Scale1-> Scale2 또는 Scale2 -> Scale1 변경 시
![image](https://user-images.githubusercontent.com/54387261/169631368-0e7f51e0-2d4b-4c88-9da1-8a769cb85caa.png)

위와 같이 설정했음에도 불구하고 Bindable의 반응이 보이질 않습니다..

향후 다시 한번 테스트해서 고쳐보는걸로....왜냐하면 기능적으론 이슈가 없어서...!!!!!!


# 문제2

Xamarin Forms에서는 별도로 수정하여 사용하셔야 합니다.

Style에 따른 부채 형태(Scale1)와 차례대로 나오는 형태(Scale1) 설정하여 xaml단에서 사용하지 않고자 하였던 방향이였으나

xamarin에서는 다음 사진과 같이 에러로 인해 처리를 할 수 없습니다.

![image](https://user-images.githubusercontent.com/54387261/169631226-49eb1e83-eae6-416b-abd8-31a8765adbfa.png)

그렇기 때문에 

[Scale1 사용시]

![image](https://user-images.githubusercontent.com/54387261/169631622-d6f9a9e2-7eb5-49e3-a09c-d4153ee763af.png)

[Scale2 사용시]

![image](https://user-images.githubusercontent.com/54387261/169631641-11fcaad5-460b-41fd-a80b-40793e1734d8.png)

각각 주석을 풀고 사용하면 됩니다.
