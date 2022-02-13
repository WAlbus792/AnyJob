import { v4 as uuid } from 'uuid';

function createUserSessionProvider() {
  const provider = {};
  const anonymousIdKey = "aj.anonymous";
  
  provider.startSession = () => localStorage.setItem(anonymousIdKey, uuid());
  provider.finishSession = () => localStorage.removeItem(anonymousIdKey);
  provider.getAnonymousId = () => localStorage.getItem(anonymousIdKey);
  
  return provider;
}

const userSessionProvider = createUserSessionProvider();
export default userSessionProvider;