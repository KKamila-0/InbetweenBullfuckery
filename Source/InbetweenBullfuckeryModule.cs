using System;
using Microsoft.Xna.Framework;
using MonoMod.ModInterop;

namespace Celeste.Mod.InbetweenBullfuckery {
    public class InbetweenBullfuckeryModule : EverestModule {
        public static InbetweenBullfuckeryModule Instance { get; private set; }

        public override Type SettingsType => typeof(InbetweenBullfuckeryModuleSettings);
        public static InbetweenBullfuckeryModuleSettings Settings => (InbetweenBullfuckeryModuleSettings) Instance._Settings;

        public override Type SessionType => typeof(InbetweenBullfuckeryModuleSession);
        public static InbetweenBullfuckeryModuleSession Session => (InbetweenBullfuckeryModuleSession) Instance._Session;

        public override Type SaveDataType => typeof(InbetweenBullfuckeryModuleSaveData);
        public static InbetweenBullfuckeryModuleSaveData SaveData => (InbetweenBullfuckeryModuleSaveData) Instance._SaveData;

        public InbetweenBullfuckeryModule() {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(InbetweenBullfuckeryModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(InbetweenBullfuckeryModule), LogLevel.Info);
#endif
        }

        public override void Load() {
            typeof(InbetweenBullfuckeryExports).ModInterop(); // TODO: delete this line if you do not need to export any functions

            // TODO: apply any hooks that should always be active
        }

        public override void Unload() {
            // TODO: unapply any hooks applied in Load()
        }
    }
}
