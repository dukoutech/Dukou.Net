using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dukou
{
    /// <summary>
    /// 环境配置
    /// </summary>
    public class EnvironmentConfig
    {
        private static EnvironmentConfig INSTANCE = null;

        private string APPSETTINGKEY = "Dukou.Environments";

        private ISet<string> ENVIRONMENTS = new HashSet<string>();

        public EnvironmentConfig()
        {
            if (INSTANCE == null)
            {
                Init(APPSETTINGKEY);
            }
        }

        public EnvironmentConfig(string appSettingKey)
        {
            if (INSTANCE == null)
            {
                APPSETTINGKEY = appSettingKey;
                Init(APPSETTINGKEY);
            }
        }

        private bool Contains(string env)
        {
            return ENVIRONMENTS.Contains(env);
        }

        private void Init(string appSettingKey)
        {
            ENVIRONMENTS = new HashSet<string>();
            var envString = System.Configuration.ConfigurationManager.AppSettings.Get(appSettingKey);
            if (!string.IsNullOrEmpty(envString))
            {
                foreach (var item in envString.Split(';'))
                {
                    if (!ENVIRONMENTS.Contains(item))
                    {
                        ENVIRONMENTS.Add(item);
                    }
                }
            }
            INSTANCE = this;
        }

        public static bool Is(string env)
        {
            if (INSTANCE == null)
            {
                return false;
            }
            return INSTANCE.Contains(env);
        }
    }
}
