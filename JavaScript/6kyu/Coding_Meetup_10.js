function addUsername(list) {
  return list.map((obj) => {
    obj['username'] = `${obj.firstName}${obj.lastName[0]}${new Date().getFullYear()-obj.age}`.toLowerCase();
    return obj;
  });
}