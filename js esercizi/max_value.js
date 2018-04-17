const fetch = require('node-fetch');

fetch('https://jsonplaceholder.typicode.com/posts')
  .then(res => res.json())
  .then(body => {
    const data = body.reduce((acc, {userId}) => {
      if (typeof acc[userId] === 'undefined') {
        acc[userId] = 1;
      } else {
        acc[userId] += userId;
      }
      return acc;
    }, {});

    const result = Object.entries(data).reduce((acc, [key, value]) => {
      if (acc.max < value) {
        acc.max = value;
        acc.id = key;
      }
      return acc;
    }, { max: 0, id: null });
    console.log(result);
  })
  .catch(console.log)
