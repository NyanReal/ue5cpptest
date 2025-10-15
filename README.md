# UE5 CPptest 프로젝트

Enhanced Input 기반의 간단한 플레이어 폰(`AStaticMeshCharacter`)을 추가했습니다. 스태틱 메시를 본체로 사용하며 이동이나 카메라 없이 발사/호흡 입력만 처리합니다. 발사는 탄약을, 호흡은 체력을 소비하고 두 수치는 델리게이트로 외부 UI와 연동할 수 있습니다.

## StaticMeshCharacter 사용법
- 에디터에서 `AStaticMeshCharacter`를 부모로 하는 블루프린트를 만들고 `CharacterMesh`에 원하는 스태틱 메시를 지정하세요.
- `MaxAmmo`, `MaxHealth`, `AmmoCostPerFire`, `HealthCostPerBreath` 값으로 기본 수치를 조정할 수 있습니다.
- 콘텐츠 브라우저에서 `IA_Fire`, `IA_Breathe` 같은 `Input Action` 에셋과 `IMC_Player`와 같은 `Input Mapping Context`를 생성한 뒤, 각각을 `FireAction`, `BreatheAction`, `DefaultMappingContext` 속성에 연결하세요.
- 플레이 인 시 로컬 플레이어 서브시스템에 매핑 컨텍스트가 자동으로 추가되며, 입력이 발생하면 `OnAmmoChanged`, `OnHealthChanged` 델리게이트가 현재 값과 최대 값을 방송합니다. 후속 UI 위젯에서 이 델리게이트를 바인딩하여 표시하면 됩니다.
- 현재는 UI 연결이 포함되어 있지 않으므로, HUD/Widget에서 델리게이트를 수신하거나 `GetCurrentAmmo`, `GetCurrentHealth` 등을 직접 호출해 수치를 가져오세요.

추가 입력이나 게임플레이 행위가 필요하면 `StaticMeshCharacter`를 확장하거나 별도 컴포넌트를 붙여 확장할 수 있습니다.
