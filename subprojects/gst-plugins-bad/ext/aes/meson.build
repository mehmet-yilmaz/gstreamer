aes_sources = [
  'gstaes.c',
  'gstaeshelper.c',
  'gstaesenc.c',
  'gstaesdec.c',
]

aes_headers = [
  'gstaesenc.h',
  'gstaeshelper.h',
  'gstaesdec.h',
]

doc_sources = []
foreach s: aes_sources + aes_headers
  doc_sources += meson.current_source_dir() / s
endforeach

plugin_sources += {
  'aes': pathsep.join(doc_sources)
}

aes_cargs = []
aes_dep = dependency('openssl', version : '>= 1.1.0', required : get_option('aes'))
if aes_dep.found()
  aes_cargs += ['-DHAVE_OPENSSL']

  gstaes = library('gstaes',
    aes_sources,
    c_args : gst_plugins_bad_args + aes_cargs,
    link_args : noseh_link_args,
    include_directories : [configinc],
    dependencies : [gstpbutils_dep, gstvideo_dep,
                    aes_dep, gio_dep, libm],
    install : true,
    install_dir : plugins_install_dir,
  )
  plugins += [gstaes]
endif
aes_dep = declare_dependency(include_directories : include_directories('.'))
