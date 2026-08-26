# TEngine 全量学习计划（进度跟踪）

> 基于仓库实际代码扫描制定（非仅文档推断）。  
> 用法：把 `[ ]` 改成 `[x]` 标记完成；可在「进度总览」更新日期与备注。


| 项目   | 内容         |
| ---- | ---------- |
| 学习者  | tro        |
| 开始日期 | 2026-08-26 |
| 预计周期 | 5～6 周      |
| 当前阶段 | Phase 0    |
| 上次更新 | 2026-08-26 |


---

## 进度总览


| 阶段      | 内容                                      | 预计      | 状态    | 完成日 |
| ------- | --------------------------------------- | ------- | ----- | --- |
| Phase 0 | 环境与总览                                   | 0.5～1 天 | ⬜ 未开始 |     |
| Phase 1 | 启动链 + 模块骨架                              | 3～4 天   | ⬜ 未开始 |     |
| Phase 2 | UI + 事件 + 资源                            | 5～6 天   | ⬜ 未开始 |     |
| Phase 3 | FSM / Procedure / Timer / Scene / Audio | 4～5 天   | ⬜ 未开始 |     |
| Phase 4 | 池化 / 本地化 / 调试 / 扩展 / 单例                 | 4～5 天   | ⬜ 未开始 |     |
| Phase 5 | 热更 + Luban + 资源服 + 打包                   | 5～6 天   | ⬜ 未开始 |     |
| Phase 6 | 编辑器工具与工程化                               | 2～3 天   | ⬜ 未开始 |     |
| 最终验收    | 串联大验收                                   | —       | ⬜ 未开始 |     |


状态建议：`⬜ 未开始` / `🟦 进行中` / `✅ 已完成` / `⏸ 搁置`

---



## 〇、系统全景清单（防遗漏）

> 状态：✅ 有实现 · 🟡 脚手架/空壳 · ❌ 文档有代码无  
> 学完某系统后，勾选右侧 `[ ]`



### A. 框架核心层 `TEngine/Runtime/Core`


| #   | 系统                    | 路径                                       | 实现  | 阶段    | 学完  |
| --- | --------------------- | ---------------------------------------- | --- | ----- | --- |
| 1   | ModuleSystem / Module | `Core/ModuleSystem.cs`, `Core/Module.cs` | ✅   | P1    | [ ] |
| 2   | GameEvent 事件          | `Core/GameEvent/`                        | ✅   | P2    | [ ] |
| 3   | MemoryPool 内存池        | `Core/MemoryPool/`                       | ✅   | P4    | [ ] |
| 4   | Log 日志                | `Core/Log/`                              | ✅   | P4    | [ ] |
| 5   | Utility 工具集           | `Core/Utility/`                          | ✅   | P4    | [ ] |
| 6   | DataStruct 数据结构       | `Core/DataStruct/`                       | ✅   | P4    | [ ] |
| 7   | GameTime 游戏时间         | `Core/GameTime/`                         | ✅   | P4    | [ ] |
| 8   | UpdateSetting 热更配置    | `Core/UpdateSetting.cs` + Settings       | ✅   | P1/P5 | [ ] |
| 9   | Constant              | `Core/Constant/`                         | ✅   | P4    | [ ] |




### B. 框架模块层 `TEngine/Runtime/Module`


| #   | 系统                       | 访问                                  | 实现  | 阶段    | 学完  |
| --- | ------------------------ | ----------------------------------- | --- | ----- | --- |
| 10  | RootModule               | `GameModule.Base`                   | ✅   | P1    | [ ] |
| 11  | UpdateDriver 帧驱动         | `IUpdateDriver`（目录名 `UpdataDriver`） | ✅   | P1    | [ ] |
| 12  | ResourceModule           | `GameModule.Resource`               | ✅   | P2    | [ ] |
| 13  | Resource 扩展（SetSprite 等） | `ResourceModule/Extension/`         | ✅   | P2    | [ ] |
| 14  | ProcedureModule          | `GameModule.Procedure`              | ✅   | P1/P3 | [ ] |
| 15  | FsmModule                | `GameModule.Fsm`                    | ✅   | P3    | [ ] |
| 16  | ObjectPoolModule         | 对象池模块                               | ✅   | P4    | [ ] |
| 17  | TimerModule              | `GameModule.Timer`                  | ✅   | P3    | [ ] |
| 18  | SceneModule              | `GameModule.Scene`                  | ✅   | P3    | [ ] |
| 19  | AudioModule              | `GameModule.Audio`                  | ✅   | P3    | [ ] |
| 20  | LocalizationModule       | `GameModule.Localization`           | ✅   | P4    | [ ] |
| 21  | DebuggerModule           | `GameModule.Debugger`（`~`）          | ✅   | P4    | [ ] |




### C. 框架扩展 `TEngine/Runtime/Extension`


| #   | 系统          | 路径                    | 实现    | 阶段  | 学完  |
| --- | ----------- | --------------------- | ----- | --- | --- |
| 22  | Json 扩展     | `Extension/Json/`     | ✅     | P4  | [ ] |
| 23  | Tween 扩展    | `Extension/Tween/`    | ✅ 接口层 | P4  | [ ] |
| 24  | Material 扩展 | `Extension/Material/` | ✅     | P4  | [ ] |




### D. AOT 启动层（不可热更）


| #   | 系统                   | 路径                                             | 实现  | 阶段  | 学完  |
| --- | -------------------- | ---------------------------------------------- | --- | --- | --- |
| 25  | GameEntry            | `GameScripts/GameEntry.cs`                     | ✅   | P1  | [ ] |
| 26  | Procedure 启动链（12 状态） | `GameScripts/Procedure/`                       | ✅   | P1  | [ ] |
| 27  | Launcher 热更阶段 UI     | `Assets/Launcher/`                             | ✅   | P1  | [ ] |
| 28  | Settings / Prefab    | Procedure/Audio/UpdateSetting、GameEntry/UIRoot | ✅   | P1  | [ ] |




### E. 热更业务层 `HotFix/`


| #   | 系统                                | 路径                           | 实现  | 阶段  | 学完  |
| --- | --------------------------------- | ---------------------------- | --- | --- | --- |
| 29  | GameApp 热更入口                      | `GameLogic/GameApp.cs`       | ✅   | P1  | [ ] |
| 30  | GameModule 门面                     | `GameLogic/GameModule.cs`    | ✅   | P1  | [ ] |
| 31  | UIModule                          | `GameLogic/Module/UIModule/` | ✅   | P2  | [ ] |
| 32  | UIWindow / UIWidget / UIBase      | 同上                           | ✅   | P2  | [ ] |
| 33  | UIBindComponent / ScriptGenerator | UI 绑定 + 生成器                  | ✅   | P2  | [ ] |
| 34  | ErrorLogger / LogUI               | 运行时错误面板                      | ✅   | P2  | [ ] |
| 35  | SetUISafeFitHelper                | 安全区适配                        | ✅   | P2  | [ ] |
| 36  | SingletonSystem                   | `GameLogic/SingletonSystem/` | ✅   | P4  | [ ] |
| 37  | 接口事件 ILoginUI                     | `GameLogic/IEvent/`          | 🟡  | P2  | [ ] |
| 38  | 示例 UI Login/BattleMain            | `GameLogic/UI/`              | 🟡  | P2  | [ ] |
| 39  | GameProto / LubanLib              | `HotFix/GameProto/`          | 🟡  | P5  | [ ] |
| 40  | ConfigSystem                      | 转表后生成                        | 🟡  | P5  | [ ] |




### F. 基础设施（第三方）


| #   | 系统                 | 位置                        | 实现  | 阶段    | 学完  |
| --- | ------------------ | ------------------------- | --- | ----- | --- |
| 41  | HybridCLR          | Package + Editor          | ✅   | P5    | [ ] |
| 42  | YooAsset           | `Packages/YooAsset`       | ✅   | P2/P5 | [ ] |
| 43  | UniTask            | `Packages/UniTask`        | ✅   | P0/P2 | [ ] |
| 44  | Luban              | `Tools/Luban` + `Configs` | 🟡  | P5    | [ ] |
| 45  | Newtonsoft.Json    | Package                   | ✅   | P4    | [ ] |
| 46  | TextMeshPro / UGUI | Package                   | ✅   | P2    | [ ] |
| 47  | Obfuz（可选）          | 条件编译                      | 🟡  | P5    | [ ] |




### G. 编辑器与工程工具


| #   | 系统                      | 路径                                       | 实现  | 阶段    | 学完  |
| --- | ----------------------- | ---------------------------------------- | --- | ----- | --- |
| 48  | UI ScriptGenerator      | `Assets/Editor/UIScriptGenerator/`       | ✅   | P2/P6 | [ ] |
| 49  | Luban 转表菜单              | `TEngine/Editor/LubanTools/`             | ✅   | P5    | [ ] |
| 50  | ReleaseTools / 打包窗口     | `TEngine/Editor/ReleaseTools/`           | ✅   | P5    | [ ] |
| 51  | HybridCLR Build DLL     | `TEngine/Editor/HybridCLR/`              | ✅   | P5    | [ ] |
| 52  | 图集 AtlasMaker           | `TEngine/Editor/AtlasMakerEditor/`       | ✅   | P6    | [ ] |
| 53  | 图集引用分析                  | `Assets/Editor/AtlasRefWindow/`          | ✅   | P6    | [ ] |
| 54  | ReferenceFinder（F10）    | `Assets/Editor/ReferenceFinder/`         | ✅   | P6    | [ ] |
| 55  | Toolbar 扩展              | SceneLauncher / PlayMode / SceneSwitcher | ✅   | P6    | [ ] |
| 56  | Define Symbols          | Log / Profiler / HybridCLR               | ✅   | P6    | [ ] |
| 57  | Settings Provider       | UpdateSettings / UISettings              | ✅   | P6    | [ ] |
| 58  | AssetBundleCollector    | `Editor/AssetBundleCollector/`           | ✅   | P5    | [ ] |
| 59  | I2 Localization Editor  | `TEngine/Editor/Localization/`           | ✅   | P4/P6 | [ ] |
| 60  | OpenFolder / Inspectors | Editor Utility / Inspector               | ✅   | P6    | [ ] |




### H. 仓库级工具与发布


| #   | 系统                        | 路径                                | 实现   | 阶段    | 学完      |
| --- | ------------------------- | --------------------------------- | ---- | ----- | ------- |
| 61  | FileServer                | `Tools/FileServer/`               | ✅    | P5    | [ ]     |
| 62  | GameEvent SourceGenerator | `Tools/GameEventSourceGenerator/` | ✅    | P2/P6 | [ ]     |
| 63  | BuildCLI                  | `BuildCLI/`                       | ✅    | P5    | [ ]     |
| 64  | AssetRaw 资源规范             | `Assets/AssetRaw/`                | ✅    | P2/P5 | [ ]     |
| 65  | Network 网络模块              | Books `3-8`                       | ❌ 跳过 | —     | [ ] N/A |


---



## Phase 0｜环境与总览

**目标**：跑起来，建立整体心智模型。

### 任务

- [x] 认清仓库：`UnityProject` / `Configs` / `Books` / `Tools` / `BuildCLI`
- [x] 理解技术栈：HybridCLR / YooAsset / UniTask / Luban
- [x] EditorMode 模拟模式 Play，看到热更成功日志
- [x] 阅读 `Books/0-介绍.md`、`1-快速开始.md`、`2-框架概览.md`、`FAQ.md`
- [x] 确认：网络模块（#65）无代码，不纳入学习



### 验收

- [x] 能指出热更代码写在哪、AOT 代码写在哪
- [x] 知道业务访问入口是 `GameModule`

**备注**：

```
（学习笔记写这里）
```

---



## Phase 1｜启动链 + 模块骨架

**覆盖系统**：#1 #8 #10 #11 #14 #25 #26 #27 #28 #29 #30

### 必读（按顺序勾选）

- [ ] `GameScripts/GameEntry.cs`
- [ ] `TEngine/Runtime/Module/RootModule.cs`
- [ ] `TEngine/Runtime/Core/ModuleSystem.cs` + `Module.cs`
- [ ] `TEngine/Runtime/Module/UpdataDriver/UpdateDriver.cs`
- [ ] `TEngine/Settings/ProcedureSetting.asset`
- [ ] `ProcedureLaunch` → `Splash` → `InitPackage` → `InitResources`
- [ ] `ProcedureCreateDownloader` → `DownloadFile` → `DownloadOver` → `ClearCache`
- [ ] `ProcedurePreload` → `LoadAssembly` → `StartGame`
- [ ] `Launcher/Scripts/LauncherMgr.cs` + LoadUpdateUI / LoadTipsUI
- [ ] `HotFix/GameLogic/GameApp.cs`
- [ ] `HotFix/GameLogic/GameModule.cs`
- [ ] `Settings/UpdateSetting.asset`（知道 DLL 列表在哪配）



### 动手

- [ ] 每个 Procedure `OnEnter` 打日志，跑通完整链
- [ ] 改 `GameApp` 默认 UI（LoginUI ↔ BattleMainUI）验证入口可控



### 验收

- [ ] 能默画：GameEntry → Procedure 链 → LoadAssembly → GameApp → ShowUI
- [ ] 能解释 ModuleSystem 注册 / Get / Update / Shutdown
- [ ] 分清 Launcher UI（Resources）与 GameModule.UI（YooAsset）

**配套文档**：`Books/3-7-流程模块.md`

**备注**：

```

```

---



## Phase 2｜UI + 事件 + 资源

**覆盖系统**：#2 #12 #13 #31～#38 #42 #43 #46 #48 #62 #64

### 2.1 UIModule

- [ ] 阅读 `UIModule.cs` / `UIWindow.cs` / `UIWidget.cs` / `UIBase.cs` / `WindowAttribute.cs`
- [ ] 掌握生命周期：ScriptGenerator → RegisterEvent → OnCreate → OnRefresh → OnDestroy
- [ ] 掌握 UILayer 与 Show / Hide / Close API
- [ ] 使用 ScriptGenerator 生成绑定代码
- [ ] 了解 `UIBindComponent`、`SetUISafeFitHelper`、`ErrorLogger/LogUI`

**练习**

- [ ] 完善 `LoginUI`：按钮关闭自身并打开 `BattleMainUI`
- [ ] `GameApp` 改为先开 LoginUI
- [ ] （可选）给 BattleMainUI 子节点练 `CreateWidget`



### 2.2 GameEvent

- [ ] int/string：`Send` / `AddEventListener` / `RemoveEventListener`
- [ ] 接口事件：`[EventInterface]` + `GameEvent.Get<T>()`
- [ ] UI 内 `AddUIEvent`（自动清理）
- [ ] `GameEventMgr` 局部作用域
- [ ] 了解 SourceGenerator（`Tools/GameEventSourceGenerator`）

**练习**

- [ ] 实现 `ILoginUI` 的 ShowLoginUI / CloseLoginUI



### 2.3 ResourceModule

- [ ] location 寻址规则（文件名，不含扩展名）
- [ ] `LoadAssetAsync` ↔ `UnloadAsset` 配对
- [ ] `LoadGameObjectAsync`（Destroy 自动卸载）
- [ ] `SetSprite` / `SetSubSprite`（不必手动释放）
- [ ] PRELOAD 标签与 `AssetRaw/` 目录约定
- [ ] 确认热更域禁止 `Resources.Load`

**练习**

- [ ] 用 `AssetRaw/UIRaw/Atlas/Battle/` 图片做一次 SetSprite



### 验收

- [ ] 独立完成带跳转的 UIWindow
- [ ] 会用接口事件打开/关闭 LoginUI
- [ ] 会正确加载/释放资源

**配套文档**：`Books/3-5-UI模块.md`、`3-2-事件模块.md`、`3-1-资源模块.md`

**备注**：

```

```

---



## Phase 3｜FSM / Procedure 深化 / Timer / Scene / Audio

**覆盖系统**：#14 #15 #17 #18 #19

### 3.1 FsmModule（重点补齐）

- [ ] 阅读 `FsmModule.cs` / `Fsm.cs` / `FsmState.cs` / `IFsm.cs` / `IFsmModule.cs`
- [ ] `CreateFsm` / `Start` / `ChangeState` / `SetData` / `DestroyFsm`
- [ ] 区分：Procedure = 游戏大阶段；Fsm = 实体/系统局部状态

**练习**

- [ ] 实现 Idle / Move / Attack（或等价）三状态 FSM 并跑通



### 3.2 Procedure 扩展

- [ ] 复习 Procedure 建立在 Fsm 之上
- [ ] （练习）新增自定义 Procedure（如 `ProcedureLogin`）并插入启动链



### 3.3 TimerModule

- [ ] `AddTimer`（单次 / 循环 / Unscaled）
- [ ] Stop / Resume / Restart / RemoveTimer
- [ ] 销毁时必须 Remove，避免空引用

**练习**

- [ ] 做 3 秒倒计时后关闭窗口或打日志



### 3.4 SceneModule

- [ ] `LoadSceneAsync` / `UnloadAsync` / Additive / `ActivateScene` / `IsContainScene`
- [ ] 理解与 Resource / YooAsset 的关系

**练习**

- [ ] 异步加载一次场景（可用 main 或自建到 AssetRaw/Scenes）



### 3.5 AudioModule

- [ ] `AudioType`：Music / Sound / UISound
- [ ] Play / Stop / StopAll / 音量开关
- [ ] 查看 `AudioSetting.asset`

**练习**

- [ ] （有音频资源时）播放 BGM + UI 点击音；无资源则先读 API 并写调用骨架



### 验收

- [ ] 独立写 `FsmState<TOwner>` 并切换状态
- [ ] 说清 Procedure 与 Fsm 的边界
- [ ] Timer / Scene / Audio 各有最小可运行示例（或等价笔记+骨架代码）

**备注**：

```

```

---



## Phase 4｜池化 / 本地化 / 调试 / 扩展 / 单例

**覆盖系统**：#3 #4 #5 #6 #7 #9 #16 #20 #21 #22 #23 #24 #36 #45 #59

### 4.1 MemoryPool

- [ ] `IMemory` / `Acquire` / `Release` 规则（Release 后禁止再用，禁止双 Release）
- [ ] Debugger 中对照 MemoryPool 窗口
- [ ] 阅读 `Books/3-3-内存池模块.md`

**练习**

- [ ] 自定义一个 `IMemory` 类型并 Acquire/Release



### 4.2 ObjectPoolModule

- [ ] `ObjectBase` / `IObjectPool<T>` / 获取释放策略
- [ ] 对比 MemoryPool：纯 C# vs Unity/资源对象池
- [ ] 了解 ResourceModule 如何用到对象池
- [ ] 阅读 `Books/3-4-对象池模块.md`

**练习**

- [ ] 最小对象池示例（或跟读 Resource 内部用法并做笔记）



### 4.3 LocalizationModule

- [ ] `GameModule.Localization` 基本 API
- [ ] `Editor/I2Localization/I2Languages.asset`
- [ ] 运行时切换语言
- [ ] I2 Editor 工具大致用途（不要求通读全部源码）

**练习**

- [ ] 切换一种语言并在 UI 验证



### 4.4 DebuggerModule

- [ ] `~` 呼出调试器
- [ ] 浏览 Console / 系统信息 / 内存池 / 对象池 / Profiler 窗口



### 4.5 Log / GameTime / Utility / DataStruct / Constant

- [ ] `Log.Debug/Info/Warning/Error/Fatal/Assert`
- [ ] `GameTime` 用途
- [ ] Utility 常用：Path / File / Unity / Reflection
- [ ] DataStruct：知道 LinkedList / MultiDictionary 存在即可
- [ ] Constant：浏览即可



### 4.6 Extension

- [ ] `Utility.Json` + Newtonsoft
- [ ] `Utility.Tween` / `ITweenHelper`（需注入才有动画）
- [ ] `Utility.MaterialHelper`



### 4.7 SingletonSystem

- [ ] `Singleton` / `SingletonBehaviour` / `SingletonSystem.Release`
- [ ] 边界：业务单例用这套；框架模块走 ModuleSystem / GameModule

**练习**

- [ ] 写一个热更 Singleton，并在 `GameApp.Release` 链路中确认清理



### 验收

- [ ] 能说清 MemoryPool vs ObjectPool
- [ ] 能切换语言文本
- [ ] 会用 Debugger 看池信息
- [ ] 热更 Singleton 正确使用与释放

**备注**：

```

```

---



## Phase 5｜热更 + Luban + 资源服 + 打包

**覆盖系统**：#8 #39 #40 #41 #42 #44 #47 #49 #50 #51 #58 #61 #63 #64

### 5.1 HybridCLR

- [ ] Install HybridCLR
- [ ] Enable HybridCLR Define Symbols
- [ ] Generate/All
- [ ] BuildAssets And CopyTo AssemblyPath
- [ ] `UpdateSetting` 与 HybridCLR Settings 同步
- [ ] 对照 `ProcedureLoadAssembly` 理解 Editor vs 真机差异
- [ ] （可选）了解 Obfuz 开关

**练习**

- [ ] 改一行热更逻辑 → 出 DLL → 验证生效



### 5.2 YooAsset 管线

- [ ] PlayMode：EditorSimulate / Offline / Host / Web
- [ ] 阅读 `AssetBundleCollectorConfig.xml`
- [ ] 走通下载链相关 Procedure
- [ ] 使用 `Tools/FileServer` 做 Host 本地托管（可选但推荐）



### 5.3 Luban

- [ ] 阅读 `Configs/GameConfig/luban.conf`、Defines、CustomTemplate
- [ ] 建立 `Datas/`（当前仓库缺失，需自建）
- [ ] 菜单 `TEngine/Luban/转表` 成功生成
- [ ] 确认输出：`GameProto/GameConfig` + `AssetRaw/Configs/bytes`
- [ ] 运行时读取配置（ConfigSystem）
- [ ] 阅读 `Books/3-6-配置表模块.md`

**练习**

- [ ] 自建一张 Item（或等价）表并在 UI/逻辑中读取



### 5.4 打包发布

- [ ] `ReleaseTools` / `BuildPipelineWindow`
- [ ] 一键打包 AssetBundle（F8）
- [ ] 浏览 `BuildCLI` Android 脚本
- [ ] 阅读 `Books/99-各平台运行RunAble.md`



### 验收

- [ ] 独立完成 HybridCLR DLL 编译验证
- [ ] Host 模式下载链路理解清楚（最好实际跑通）
- [ ] 自建表 + 转表 + 代码读取
- [ ] 打出 AB / 理解 collector 分组

**备注**：

```

```

---



## Phase 6｜编辑器工具与工程化

**覆盖系统**：#48～#60 #62

### 工具清单（会用即可，不必改源码）

- [ ] ScriptGenerator（UI 绑定，必须熟练）
- [ ] Toolbar：EditorPlayMode / SceneLauncher / SceneSwitcher
- [ ] ReferenceFinder（F10）
- [ ] AtlasMaker + AtlasRefWindow
- [ ] Define Symbols（Log / Profiler / HybridCLR）
- [ ] Settings Provider（UpdateSettings / UISettings）
- [ ] Inspectors：RootModule / ProcedureSetting / ResourceModuleDriver
- [ ] OpenFolderHelper
- [ ] GameEvent SourceGenerator 工作原理回顾
- [ ] I2 Localization Editor 入口熟悉



### 验收

- [ ] 不查文档也能找到并使用上述主菜单工具
- [ ] 能解释 UpdateSetting 热更 DLL 列表含义

**备注**：

```

```

---



## 最终大验收

- [ ] 讲清分层：Core / Module / Extension / AOT Procedure / HotFix
- [ ] 能用 `GameModule` 正确使用：UI、Resource、Fsm、Procedure、Timer、Scene、Audio、Localization、Debugger
- [ ] 区分并会用：MemoryPool vs ObjectPool、Procedure vs Fsm、Launcher UI vs Game UI
- [ ] 独立完成：Login→主界面、事件驱动、配置表读取、资源加载释放
- [ ] 独立完成：热更 DLL 构建 + AB 构建 +（可选）Host 下载验证
- [ ] 日常工具：ScriptGenerator、引用查找、图集、打包菜单都会用

**完成日期**：__________

---



## 周计划对照（可选勾选）


| 周      | 内容                | 状态  |
| ------ | ----------------- | --- |
| Week 1 | Phase 0 + Phase 1 | [ ] |
| Week 2 | Phase 2           | [ ] |
| Week 3 | Phase 3（含 FSM）    | [ ] |
| Week 4 | Phase 4           | [ ] |
| Week 5 | Phase 5           | [ ] |
| Week 6 | Phase 6 + 最终验收    | [ ] |


---



## 明确跳过 / 后置


| 项                     | 原因                       | 决定      |
| --------------------- | ------------------------ | ------- |
| Network（#65）          | Books 写「待补充」，Runtime 无实现 | 跳过      |
| Localization 全部 I2 源码 | 先会用 API，内部按需深挖           | 后置      |
| DataStruct 逐行精读       | 框架内部用，业务少碰               | 后置      |
| Obfuz                 | 可选安全加固                   | 热更跑通后再开 |


---



## 学习日志

> 每次学习后追加一条，便于回顾。



### 2026-08-26

- 制定全量学习计划文档
- 当前阶段：Phase 0



### YYYY-MM-DD

- 

---



## 相关入口


| 类型               | 路径                                                               |
| ---------------- | ---------------------------------------------------------------- |
| 官方快速开始           | [1-快速开始.md](./1-快速开始.md)                                         |
| 框架概览             | [2-框架概览.md](./2-框架概览.md)                                         |
| AI 规范 references | `UnityProject/.codex/skills/tengine-dev/references/`             |
| 热更入口代码           | `UnityProject/Assets/GameScripts/HotFix/GameLogic/GameApp.cs`    |
| 模块门面             | `UnityProject/Assets/GameScripts/HotFix/GameLogic/GameModule.cs` |


