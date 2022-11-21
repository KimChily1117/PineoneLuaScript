#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class PineonePlayerControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(PineonePlayerController);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Move", _m_Move);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "_speed", _g_get__speed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", _g_get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Obj", _g_get_Obj);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "_speed", _s_set__speed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "transform", _s_set_transform);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Obj", _s_set_Obj);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new PineonePlayerController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to PineonePlayerController constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Move(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Move(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked._speed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Obj(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Obj);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set__speed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked._speed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_transform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.transform = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Obj(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                PineonePlayerController gen_to_be_invoked = (PineonePlayerController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Obj = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
