
Vue.use(Autocomplete);
movies = {}

// Vue.js objekt not found teksti jaoks.
var notfound = new Vue({
  el: '#notfound',
  data: {
    show: false
  },
  methods: {
    // Funktsioon, mis peidab not found list elemendi ja kuvab kõik filmid.
    showall: function (event) {
      this.show = false;
      searchbar.result = null;
      searchbar.searching = false;
      vu.info = movies;
    }
  }
})

// Vue.js objekt otsingu jaoks.
var searchbar = new Vue({
  el: '#searchbar',
  data: {
    result: null,
    searching: false
  },
  methods: {
    // funktsioon, mida kutsutakse, kui vajutatakse enterit või seartch nuppu
    // Käib läbi movies listi(initsialiseeritud üleval pool) ja võrdleb tiitlit. 
    search: function (event) {
        this.searching = true;
        notfound.show = false;
        s_title = $("#search_in").val();
        let found = false;
        vu.info = [];
        this.result = null;
        movies.forEach(function(entry) {
          if (entry.title.toLowerCase().includes(s_title.toLowerCase())) {
            vu.info.push(entry);
            found = true;
          }
        })
        this.result = vu.info;
        if (!found) {
          this.searching = false;
          this.result = null;
          notfound.show = true;
        }
        // axios
        //   .get('/api/fetchbyid?id='+id)
        //   .then(response => (this.result = response.data))
        //   .then(vu.fetch)
        //   .catch(error => console.log(error));
        
    },
    // funktsioon autocomplete jaoks.
    // Kasutab vue.js autocomplete komponenti. https://autocomplete.trevoreyre.com/#/vue-component
    auto(input) {
      if (input.length < 1) { return []}
      return movies.filter(movie => {
        return movie.title.toLowerCase().includes(input.toLowerCase())
      })
    },
    // funktsioon autocomplete jaoks. Saab json formaadist tiitli.
    getResultValue(result) {
      return result.title
    }
  }
})

// Vue.js objekt listi jaoks.
var vu = new Vue({
    el: '#app',
    data: {
        // Info on filmide data saadud api-st
        // Cats on kategooria data saadud api-st
        info: null,
        cats: null
    },
    // Kui element on kinnitatud, siis otsi filme (uuendab kui data muutub)
    mounted () {
      this.fetch(true);
    },
    methods: {
      // GET request /api/ urlile
      // saab filmide data ja kategooria data
      fetch: function (first = false) {
        // kui esimene kutse, siis täida movies list ja saa kategooriad, edaspidi pole vaja.
        if (first) {
          axios
          .get('/api/fetch')
          .then(response => (this.info = response.data, movies = response.data))
          .catch(error => console.log(error));
          axios
          .get('/api/fetchcat')
          .then(response => (this.cats = response.data))
          .catch(error => console.log(error))
        } else {
          axios
          .get('/api/fetch')
          .then(response => (this.info = response.data))
          .catch(error => console.log(error))
        }
      }
    }
  }
  )

// Vue.js objekt filtri menüü jaoks
var f_menu = new Vue({
  el: '#menu',
  data: {
    // filtrid
    filters: {
      action: false,
      drama: false,
      comedy: false,
      romance: false,
      crime: false
    },
  },
  methods: {
    // Kui filtri nupp vajutatud, siis muuda booleani ja kontrolli filtreid
    toggle: function (name) {
      this.filters[name] = !this.filters[name];
      this.scan();
    },
    // Käib läbi filtrid ja kui active siis käib läbi filmid. Filtriga sobivad filmid paneb listi.
    scan: function () {
      notfound.show = false;
      if (searchbar.searching) {
        temp = searchbar.result;
      } else {
        temp = movies;
      }
      vu.info = [];
      var found = false;
      var filter_on = false;
      vu.cats.forEach(function (cat) {
        if (this.filters[cat.name.toLowerCase()]) {
          filter_on = true;
          temp.forEach( function (movie) {
            if (movie.categoryId == cat.id) {
              vu.info.push(movie);
              found = true;
            }
          })
        }
      }, this)
      if (!found && filter_on) {
        notfound.show = true;
      } else if (!filter_on) {
        vu.info = temp;
      }
    }
  }
})

// kood kopeeritud stackoverflowst, eemaldab html formi submit on enteri.
// Kui enter, siis otsi.
$('#searchbar').on('keyup keypress', function(e) {
  var keyCode = e.keyCode || e.which;
  if (keyCode === 13) {
    searchbar.search(); 
    e.preventDefault();
    return false;
  }
});


// Enamus koodist all pool saadud bootstrapi dokumentatsioonist, veidi muudetud
// Muudab modali infot movie id järgi, mille saab buttonilt.
$('#exampleModal').on('show.bs.modal', function (event) {
  var button = $(event.relatedTarget); // Button that triggered the modal
  var movieid = button.attr('data-id'); // Extract info from data-* attributes
  var movie;
  movies.forEach(function(entry) {
    if (entry.id == movieid) {
      movie = entry;
    }
  })
  var modal = $(this);
  modal.find('.modal-title').text(movie.title);
  modal.find('#desc').text(movie.description);
  modal.find('#rating').text(movie.rating + "/10");
  modal.find('#year').text(movie.year);
})

// Ei sulge filter dropdown menu-t kui vajutad nupule.
$('.filter-btn').bind('click', function (e) { e.stopPropagation(); $(this).button('toggle') })
